using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GroundControlStation
{
    public partial class MapTest : Form
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public MapTest()
        {
            // 元件初始化。
            InitializeComponent();
            // 控制流程。
            Execute();
        }

        /// <summary>
        /// 執行。
        /// </summary>
        void Execute()
        {
            // 地圖初始化。
            Models.FlightData.Map.InitialieMap(GMapControl1);
            
        }
    }
}
