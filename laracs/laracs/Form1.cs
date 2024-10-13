using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using laracs.Models;

namespace laracs
{
    public partial class Form1 : Form
    {
        public static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async Task GetDataSiswa()
        {
            try
            {
                var response = await client.GetAsync("http://localhost:8000/api/siswa");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var siswaList = JsonConvert.DeserializeObject<List<Siswa>>(responseBody);

                dataGridView1.DataSource = siswaList;
            } 
            catch (HttpRequestException ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task InsertOrEditDataSiswa(Siswa siswa)
        {
            try
            {
                if (siswa.Id == 0)
                {
                    var jsonSerialize = JsonConvert.SerializeObject(siswa);
                    var content = new StringContent(jsonSerialize, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("http://localhost:8000/api/siswa", content);
                    response.EnsureSuccessStatusCode();

                    var msg = MessageBox.Show("Berhasil menambahkan data!", "Sukses", MessageBoxButtons.OK);

                    if (msg == DialogResult.OK)
                    {
                        GetDataSiswa();
                    }
                }
                else
                {
                    var jsonSerialize = JsonConvert.SerializeObject(siswa);
                    var content = new StringContent(jsonSerialize, Encoding.UTF8, "application/json");

                    var response = await client.PutAsync($"http://localhost:8000/api/siswa/{siswa.Id}", content);
                    response.EnsureSuccessStatusCode();

                    var msg = MessageBox.Show("Berhasil mengubah data!", "Sukses", MessageBoxButtons.OK);

                    if (msg == DialogResult.OK)
                    {
                        GetDataSiswa();
                    }
                }

                bindingSource1.Clear();
                bindingSource1.DataSource = new Siswa();

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task DetailDataSiswa(int Id)
        {
            try
            {
                var response = await client.GetAsync($"http://localhost:8000/api/siswa/{Id}");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var getSiswa = JsonConvert.DeserializeObject<Siswa>(responseBody);

                bindingSource1.DataSource = getSiswa;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task DeleteDataSiswa(int Id)
        {
            try
            {
                var response = await client.DeleteAsync($"http://localhost:8000/api/siswa/{Id}");
                response.EnsureSuccessStatusCode();

                var msg = MessageBox.Show("Berhasil menghapus!", "Sukses", MessageBoxButtons.OK);

                if (msg == DialogResult.OK)
                {
                    GetDataSiswa();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            GetDataSiswa();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Siswa siswa)
            {
                if (e.ColumnIndex == editCol.Index)
                {
                    e.Value = "Edit";
                }
                if (e.ColumnIndex == delCol.Index)
                {
                    e.Value = "Delete";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Siswa siswa)
            {
                InsertOrEditDataSiswa(siswa);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            bindingSource1.DataSource = new Siswa();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Siswa siswa)
            {
                if (e.ColumnIndex == editCol.Index)
                {
                    DetailDataSiswa(siswa.Id);
                }
                if (e.ColumnIndex == delCol.Index)
                {
                    var msg = MessageBox.Show($"Apakah kamu yakin menghapus {siswa.nama} dari daftar?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (msg == DialogResult.Yes)
                    {
                        DeleteDataSiswa(siswa.Id);
                    }
                }
            }
        }
    }
}
