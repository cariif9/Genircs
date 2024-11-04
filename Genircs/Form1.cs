using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genircs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student<String> Newstudent = new Student<String>();
            Newstudent.Name = "Mohamed";
            Newstudent.Mobile = "0615434533";
            Newstudent.Address = "Kaxda";

            MessageBox.Show("Your Name is "+Newstudent.Name + "\n"+ "Your Mobile Phone is "+ Newstudent.Mobile + "\n" + "Your Addres is "+Newstudent.Address, "Student Info");
            
            

        }
    }

    class Student<T>
    {
        public T Name { get; set; }
        public T Address { get; set; }
        
        public T Mobile { get; set; }

        public Student() { }

        public void StudnDisplay() {

            
        
        }
    }

}
