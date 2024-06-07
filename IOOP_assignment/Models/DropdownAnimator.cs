using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment.Models
{
    public class DropdownAnimator
    {
        private Timer _timer;
        private Panel _dropdownPanel;
        private bool _isDroppedDown;
        private int _targetHeight;
        private int _stepSize;

        public DropdownAnimator(Panel dropdownPanel, int targetHeight = 300, int stepSize = 10)
        {
            _dropdownPanel = dropdownPanel;
            _targetHeight = targetHeight;
            _stepSize = stepSize;
            _isDroppedDown = false;

            _timer = new Timer();
            _timer.Interval = 20; 
            _timer.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (_isDroppedDown)
            {
                _dropdownPanel.Height -= _stepSize;
                if (_dropdownPanel.Height <= 10)
                {
                    _dropdownPanel.Height = 10;
                    _timer.Stop();
                    _isDroppedDown = false;
                }
            }
            else
            {
                _dropdownPanel.Height += _stepSize;
                if (_dropdownPanel.Height >= _targetHeight)
                {
                    _dropdownPanel.Height = _targetHeight;
                    _timer.Stop();
                    _isDroppedDown = true;
                }
            }
        }

        public void Toggle()
        {
            _timer.Start();
        }
    }
}
