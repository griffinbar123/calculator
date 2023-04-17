// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Calc
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField InputText { get; set; }

		[Outlet]
		AppKit.NSTextField OutputText { get; set; }

		[Action ("ACButton:")]
		partial void ACButton (AppKit.NSButton sender);

		[Action ("DivButton:")]
		partial void DivButton (AppKit.NSButton sender);

		[Action ("DotButton:")]
		partial void DotButton (AppKit.NSButton sender);

		[Action ("EightButton:")]
		partial void EightButton (AppKit.NSButton sender);

		[Action ("EqualsButton:")]
		partial void EqualsButton (AppKit.NSButton sender);

		[Action ("FiveButton:")]
		partial void FiveButton (AppKit.NSButton sender);

		[Action ("FourButton:")]
		partial void FourButton (AppKit.NSButton sender);

		[Action ("MinusButton:")]
		partial void MinusButton (AppKit.NSButton sender);

		[Action ("ModButton:")]
		partial void ModButton (AppKit.NSButton sender);

		[Action ("MultButton:")]
		partial void MultButton (AppKit.NSButton sender);

		[Action ("NegateButton:")]
		partial void NegateButton (AppKit.NSButton sender);

		[Action ("NineButton:")]
		partial void NineButton (AppKit.NSButton sender);

		[Action ("OneButton:")]
		partial void OneButton (AppKit.NSButton sender);

		[Action ("PlusButton:")]
		partial void PlusButton (AppKit.NSButton sender);

		[Action ("SevenButton:")]
		partial void SevenButton (AppKit.NSButton sender);

		[Action ("SixButton:")]
		partial void SixButton (AppKit.NSButton sender);

		[Action ("ThreeButton:")]
		partial void ThreeButton (AppKit.NSButton sender);

		[Action ("TwoButton:")]
		partial void TwoButton (AppKit.NSButton sender);

		[Action ("ZeroButton:")]
		partial void ZeroButton (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (InputText != null) {
				InputText.Dispose ();
				InputText = null;
			}

			if (OutputText != null) {
				OutputText.Dispose ();
				OutputText = null;
			}
		}
	}
}
