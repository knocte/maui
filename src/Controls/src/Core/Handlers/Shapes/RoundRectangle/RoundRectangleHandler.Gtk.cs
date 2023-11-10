﻿using Microsoft.Maui.Controls.Shapes;

namespace Microsoft.Maui.Controls.Handlers
{
	public partial class RoundRectangleHandler
	{

		public static void MapCornerRadius(IShapeViewHandler handler, RoundRectangle roundRectangle)
		{
			handler.PlatformView?.UpdateShape(roundRectangle);
		}
	}
}
