using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Windows.Forms;

namespace GroundControlStation.Models.FlightData
{
    /// <summary>
    /// 地圖類別。
    /// </summary>
    public class Map
    {
        /// <summary>
        /// 地圖初始化。
        /// </summary>
        /// <param name="gmap">GMap控制項ID</param>
        public static void InitialieMap(GMapControl gmap)
        {
            // 選擇地圖供應商 - 這邊採用 微軟的 bing Map。
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            // 開啟拖曳功能。
            gmap.DragButton = MouseButtons.Left;
            // 存取模式。
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            // 設定地圖中心
            gmap.Position = new PointLatLng(23.721379342900296, 120.924267578125);
            // 初始大小
            gmap.Zoom = 7;
            // 最大縮放
            gmap.MaxZoom = 15;
            // 最小縮放
            gmap.MinZoom = 0;
        }
    }
}
