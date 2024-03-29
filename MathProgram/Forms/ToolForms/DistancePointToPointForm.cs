﻿using MathProgram.Interfaces;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MathLib;
using MathProgram.Static;
using MathLib.Distance;

namespace MathProgram.Forms
{
    public partial class DistancePointToPointForm : DockContent
    {
        private PointToPointTool distanceFormular = new PointToPointTool();

        /* Init & uninit section *********************/
        public DistancePointToPointForm()
        {
            InitializeComponent();

            IC_Main.SetGeometry(distanceFormular);
            IC_Main.SetInput(distanceFormular);
            distanceFormular.Calculation += OnCalulation;
            distanceFormular.Calculate();
        }

        public void OnCalulation()
        {
            DC_Length.Update(
                distanceFormular.GetLengthCalculation(),
                distanceFormular.GetLengthResult()
            );
            DC_MidPoint.Update(
                distanceFormular.GetMidPointCalculation(),
                distanceFormular.GetMidPointResult()
            );
            CoordinateSystemForm.Program.Update();
        }
    }
}
