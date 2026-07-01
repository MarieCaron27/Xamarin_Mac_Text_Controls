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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField FeedBackLabel { get; set; }

		[Outlet]
		AppKit.NSTextField NumberTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField PasswordTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField UserNameTxtField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (NumberTxtField != null) {
				NumberTxtField.Dispose ();
				NumberTxtField = null;
			}

			if (PasswordTxtField != null) {
				PasswordTxtField.Dispose ();
				PasswordTxtField = null;
			}

			if (UserNameTxtField != null) {
				UserNameTxtField.Dispose ();
				UserNameTxtField = null;
			}

			if (FeedBackLabel != null) {
				FeedBackLabel.Dispose ();
				FeedBackLabel = null;
			}

		}
	}
}
