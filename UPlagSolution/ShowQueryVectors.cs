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
        public Algorithm MyProperty { get; set; }

        public ShowQueryVectors()
        {
            InitializeComponent();
        }
    }
}