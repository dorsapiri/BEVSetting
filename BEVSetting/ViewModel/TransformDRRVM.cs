using Kitware.VTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BEVSetting.ViewModel
{
    public class TransformDRRVM :INotifyPropertyChanged
    {
        #region Properties
        #region Property Changed
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #region Gant Angel prop
        private int _txtGantAngel = 0;
        public int txtGantAngel
        {
            get { return _txtGantAngel; }
            set
            {
                _txtGantAngel = value;
                onPropertyChanged(nameof(txtGantAngel));
            }
        }
        #endregion
        #region Table Angle Prop
        private int _txtTableAngle = 0;
        public int txtTableAngle
        {
            get { return _txtTableAngle; }
            set
            {
                _txtTableAngle = value;
                onPropertyChanged(nameof(txtTableAngle));
            }
        }
        #endregion
        private MainWindowVM _vm;
        #endregion
        #region Methods
        #region Constructor
        public TransformDRRVM(MainWindowVM mainWindowVM)
        {
            _vm = mainWindowVM;
        }
        #endregion
        #region Calculate Drr Button
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            var imagedata = _vm.transformedImageData;
            var drrRotation = _vm.DRRrotation(imagedata, txtGantAngel, txtTableAngle);
            _vm.RenderDicom(drrRotation);
        }
        #endregion
        #endregion
    }
}
