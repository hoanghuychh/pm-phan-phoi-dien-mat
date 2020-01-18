﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjectBNG
{
    public partial class frmNoiGui : Form
    {
        public frmNoiGui()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            ProjectBNG.Models.SMMgEntities dbContext = new ProjectBNG.Models.SMMgEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.NoiGuis.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    noiGuisBindingSource.DataSource = dbContext.NoiGuis.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
