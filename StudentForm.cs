using Mendoza_Mariela_Act_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mendoza_Mariela_Act_GUI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Mariela Kim Mendoza";
            StudentAgeLabel.Text = "21";
            StudentAddressLabel.Text = "Malasiqui";
            StudentContactLabel.Text = "090987654321";
            StudentEmailLabel.Text = "kimmaganda@sample.com";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "Marlon Mendoza";
            ParentContactLabel.Text = "091234567890";
            HobbiesLabel.Text = "Crocheting, Singing, Dancing";
            NicknameLabel.Text = "Christina";
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

        private void StudentNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}