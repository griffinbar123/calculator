using System;

using AppKit;
using Foundation;

namespace Calc
{
	public partial class ViewController : NSViewController
	{
        private Solver solver;
		public ViewController (IntPtr handle) : base (handle)
		{
            solver = new Solver();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

        //functions to handle the numerical buttons
        partial void ZeroButton(NSButton sender)
        {
            InputText.StringValue += "0";
            solver.Accumulate(InputText.StringValue);

        }
        partial void OneButton(NSButton sender)
		{
			InputText.StringValue += "1";
            solver.Accumulate(InputText.StringValue);
        }
        partial void TwoButton(NSButton sender)
        {
            InputText.StringValue += "2";
            solver.Accumulate(InputText.StringValue);
        }
        partial void ThreeButton(NSButton sender)
        {
            InputText.StringValue += "3";
            solver.Accumulate(InputText.StringValue);
        }
        partial void FourButton(NSButton sender)
        {
            InputText.StringValue += "4";
            solver.Accumulate(InputText.StringValue);
        }
        partial void FiveButton(NSButton sender)
        {
            InputText.StringValue += "5";
            solver.Accumulate(InputText.StringValue);
        }
        partial void SixButton(NSButton sender)
        {
            InputText.StringValue += "6";
            solver.Accumulate(InputText.StringValue);
        }
        partial void SevenButton(NSButton sender)
        {
            InputText.StringValue += "7";
            solver.Accumulate(InputText.StringValue);
        }
        partial void EightButton(NSButton sender)
        {
            InputText.StringValue += "8";
            solver.Accumulate(InputText.StringValue);
        }
        partial void NineButton(NSButton sender)
        {
            InputText.StringValue += "9";
            solver.Accumulate(InputText.StringValue);
        }

        //functions to handle the operations
        partial void DivButton(NSButton sender)
        {
            InputText.StringValue += "/";
            solver.Accumulate(InputText.StringValue);
        }
        partial void PlusButton(NSButton sender)
        {
            InputText.StringValue += "+";
            solver.Accumulate(InputText.StringValue);
        }
        partial void MinusButton(NSButton sender)
        {
            InputText.StringValue += "-";
            solver.Accumulate(InputText.StringValue);
        }
        partial void MultButton(NSButton sender)
        {
            InputText.StringValue += "*";
            solver.Accumulate(InputText.StringValue);
        }

        //handles equal button
        partial void EqualsButton(NSButton sender)
        {
            OutputText.StringValue = solver.Solve().ToString();
        }

        //functions to handle miscellaneous buttons
        partial void ACButton(NSButton sender)
        {
            InputText.StringValue = "";
            OutputText.StringValue = "";
            solver.Clear();
        }
        partial void NegateButton(NSButton sender)
        {
            InputText.StringValue += "-"; // i thought i was supposed to negate this like on iphone, but the instructions say to just add the '-' to the input
            solver.Accumulate(InputText.StringValue);
        }
        partial void ModButton(NSButton sender)
        {
            InputText.StringValue += "%";
            solver.Accumulate(InputText.StringValue);
        }
        partial void DotButton(NSButton sender)
        {
            InputText.StringValue += ".";
            solver.Accumulate(InputText.StringValue);
        }
    }
}
