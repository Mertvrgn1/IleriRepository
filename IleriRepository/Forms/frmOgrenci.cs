using IleriRepository.Concrete;
using IleriRepository.DTO;
using IleriRepository.Repositories.BaseRepository.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository.Forms
{
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }
        StudentRepository stuRep = new StudentRepository();
        CountyRepository countyRep = new CountyRepository();
        CityRepository cityRep = new CityRepository();
        EducationRepository eduRep = new EducationRepository();
        Student SelectedStu;
        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            GetStudents();
            GetEducation();
            GetCity();
            

        }

        private void GetCity()
        {
            cityRep.GetCombo(cmbSehir);
        }

        private void GetEducation()
        {
            eduRep.GetCombo(cmbEgitim);
        }

        private void GetStudents()
        {
            dataGridView1.DataSource = stuRep.SummaryList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SecId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SelectedStu = stuRep.Set().Find(SecId);
            txOzet.Text = SelectedStu.GetTitle() + " " + SelectedStu.GetAge();

            txAd.Text=SelectedStu.Name;
            txSoyad.Text = SelectedStu.Surname;
            txBolum.Text = SelectedStu.UniversityDep;
            txCaade.Text = SelectedStu.Street;
            txSokak.Text = SelectedStu.Avenue;
            txKapıNo.Text = SelectedStu.HouseNumber;
            dTP.Value = SelectedStu.BirthofDate;
            cmbEgitim.SelectedValue = SelectedStu.EducationId;
            cmbIlce.SelectedValue = SelectedStu.CountyId;
            cmbSehir.SelectedValue = SelectedStu.County.CityId;
            
           
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            countyRep.GetCombo(cmbIlce, (int)cmbSehir.SelectedValue);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Name = txAd.Text;
            stu.Surname = txSoyad.Text;
        }
    }
}
