using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomRenderersSample
{
    // Labelを継承したCustomLabelクラスを共通プロジェクトに配置する
    public class CustomLabel : Label
    {
        private string _customText;

        public string customText
        {
            get { return _customText; }
            set
            {
                this.Text = value + "のCustom Renderer";
                _customText = value;
            }
        }
    }
}
