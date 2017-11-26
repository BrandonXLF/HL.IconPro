﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL.MVVM;

namespace HL.IconPro.MVVM.Models
{
    class FrameSizeModel : ModelBase
    {
        #region Constructors
        public FrameSizeModel(System.Windows.Size Source)
        {
            _Size = string.Format("{0} x {1}", new object[] { Source.Width.ToString(), Source.Height.ToString() });
            _Enabled = true;
            if (Source.Width == 16) _Enabled = false;
            _Checked = true;
        }
        #endregion

        #region Destructors

        #endregion

        #region Fields
        private string _Size;
        private bool _Enabled;
        private bool _Checked;
        #endregion

        #region Properties
        public string Size
        {
            get { return _Size; }
            set
            {
                SetField(ref _Size, value);
            }
        }
        public bool Enabled
        {
            get { return _Enabled; }
            set
            {
                SetField(ref _Enabled, value);
            }
        }
        public bool Checked
        {
            get { return _Checked; }
            set
            {
                SetField(ref _Checked, value);
            }
        }
        #endregion

        #region Procedures
        public System.Windows.Size GetSize()
        {
            double width = 0, height = 0;
            string[] values = Size.Split(new string[] { " x " }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                width = double.Parse(values[0]);
                height = double.Parse(values[1]);
            }
            catch { }
            return new System.Windows.Size(width, height);
        }
        #endregion

        #region Static

        #endregion

        #region Others

        #endregion
    }
}
