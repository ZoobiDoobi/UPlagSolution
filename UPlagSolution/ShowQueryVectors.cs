﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UPlagSolution.AlgorithmModules;

namespace UPlagSolution
{
    public partial class ShowQueryVectors : MetroForm
    {
        public Algorithm AlgorithmObject { get; set; }

        public ShowQueryVectors()
        {
            InitializeComponent();
        }

        private void btnShowQueryVectors_Click(object sender, EventArgs e)
        {
            double[] queryVectorsToShow = AlgorithmObject.FinalQueryVectors;
            foreach (var item in queryVectorsToShow)
            {
                txtQueryVetors.Text += item.ToString("0.0000") + Environment.NewLine;
            }
            List<double> similarities = AlgorithmObject._similarities;
            foreach (var item in similarities)
            {
                txtSimilarities.Text += item.ToString("0.0000") + Environment.NewLine;
            }
        }

        private void btnBackLowApproximation_Click(object sender, EventArgs e)
        {
            new ShowRankApprox().Visible = true;
            Visible = false;
        }

        private void btnBackInputForm_Click(object sender, EventArgs e)
        {
            new InputForm().Visible = true;
            Visible = false;
        }
    }
}
