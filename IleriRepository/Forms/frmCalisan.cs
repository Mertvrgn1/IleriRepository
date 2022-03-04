using IleriRepository.Concrete;
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
    public partial class frmCalisan : Form
    {
        public frmCalisan()
        {
            InitializeComponent();
        }
        EmpRepository empRep = new EmpRepository();
        EducationRepository eduRep = new EducationRepository();
        CountyRepository countyRep = new CountyRepository();
        CityRepository cityRep = new CityRepository();
        Employees SelectedEmp;
        private void frmCalisan_Load(object sender, EventArgs e)
        {
            
            GetEmployees();           
            GetCity();
            GetEducation();
            
            
        }

        

        private void GetEducation()
        {
            eduRep.GetCombo(cmbEgitim);
        }


        private void GetCity()
        {
           cityRep.GetCombo(cmbSehir);
        }
       

        private void GetEmployees()
        {
            dataGridView1.DataSource = empRep.SummaryList();
        }

        /*private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cRep.GetCombo(cmbIlce, (int)cmbSehir.SelectedValue);
        }*/

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SelectedEmp = empRep.Find(secId);
            txHead.Text = SelectedEmp.GetTitle() + " " + SelectedEmp.GetAge();
            
            txAd.Text = SelectedEmp.Name;
            txSoyad.Text = SelectedEmp.Surname;
            txCaade.Text = SelectedEmp.Street;
            txMaas.Text = SelectedEmp.Salary.ToString();           
            txSokak.Text = SelectedEmp.Avenue;
            txKapıNo.Text = SelectedEmp.HouseNumber;
            cmbIlce.SelectedValue = SelectedEmp.CountyId;
            cmbSehir.SelectedValue = SelectedEmp.County.CityId;
            cmbEgitim.SelectedValue = SelectedEmp.EducationId;
            dTP.Value = SelectedEmp.BirthofDate;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.Name = txAd.Text;
            emp.Surname = txSoyad.Text;
            emp.Salary =Convert.ToInt32(txMaas.Text);
            emp.Street = txCaade.Text;
            emp.Avenue = txSokak.Text;
            emp.HouseNumber = txKapıNo.Text;
            emp.BirthofDate = dTP.Value;
            emp.CountyId = (int)cmbIlce.SelectedValue;
            //emp.County.CityId = (int)cmbSehir.SelectedValue;
            emp.EducationId = (int)cmbEgitim.SelectedValue;
            empRep.Add(emp);
            empRep.Update();
            GetEmployees();

            
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            countyRep.GetCombo(cmbIlce, (int)cmbSehir.SelectedValue);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            empRep.Delete(SelectedEmp);
            empRep.Update();
            GetEmployees();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SelectedEmp.Name = txAd.Text;
            SelectedEmp.Surname = txSoyad.Text;
            SelectedEmp.Salary = Convert.ToInt32(txMaas.Text);
            SelectedEmp.Street = txCaade.Text;
            SelectedEmp.Avenue = txSokak.Text;
            SelectedEmp.HouseNumber = txKapıNo.Text;
            SelectedEmp.BirthofDate = dTP.Value;
            SelectedEmp.CountyId = (int)cmbIlce.SelectedValue;
            //emp.County.CityId = (int)cmbSehir.SelectedValue;(Eklersen Hata veriyor çünkü veritabannda yok ve zaten countyıd sehıre baglı)
            SelectedEmp.EducationId = (int)cmbEgitim.SelectedValue;           
            empRep.Update();
            GetEmployees();

        }
    }
}
