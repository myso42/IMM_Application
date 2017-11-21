using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework.Controls;

namespace IMM_ApplicationCrossLayer
{
    public class ScreenManager
    {
        public static MetroUserControl MainUserControl { get; set; }

        private static IList<MetroUserControl> _userControls = null;

        public static IList<MetroUserControl> UserControls
        {
            get
            {
                if(_userControls == null)
                    _userControls = new List<MetroUserControl>();

                return _userControls;
            }
        }

        public static void AddScreen(MetroUserControl control)
        {
            if (control != null && UserControls != null)
            {
                _userControls.Add(control);
                MainUserControl = control;
            }
        }

        public static void BackToPreviousScreen()
        {
            if (_userControls.Count > 1 && MainUserControl != null)
            {
                int currentIndexUC = _userControls.Count - 1;
                _userControls.RemoveAt(currentIndexUC); //Supprimer l'UserControl de la liste

                MainUserControl = _userControls[currentIndexUC - 1];
            }
        }
    }
}
