// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace controles_de_text
{
	[Register ("VoletViewController")]
	partial class VoletViewController
	{
		[Outlet]
		AppKit.NSTabViewItem FirstTab { get; set; }

		[Outlet]
		AppKit.NSTextField FirstTxtField { get; set; }

		[Outlet]
		AppKit.NSTabViewItem SecondTab { get; set; }

		[Outlet]
		AppKit.NSTextField SecondTxtField { get; set; }

		[Outlet]
		AppKit.NSTabViewItem ThirdTab { get; set; }

		[Outlet]
		AppKit.NSTextField ThirdTxtField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (FirstTab != null) {
				FirstTab.Dispose ();
				FirstTab = null;
			}

			if (SecondTab != null) {
				SecondTab.Dispose ();
				SecondTab = null;
			}

			if (ThirdTab != null) {
				ThirdTab.Dispose ();
				ThirdTab = null;
			}

			if (ThirdTxtField != null) {
				ThirdTxtField.Dispose ();
				ThirdTxtField = null;
			}

			if (SecondTxtField != null) {
				SecondTxtField.Dispose ();
				SecondTxtField = null;
			}

			if (FirstTxtField != null) {
				FirstTxtField.Dispose ();
				FirstTxtField = null;
			}

		}
	}
}
