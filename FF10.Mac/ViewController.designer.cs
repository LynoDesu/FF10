// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FF10.Mac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField lblOverdrivePercent { get; set; }

		[Outlet]
		AppKit.NSSlider sliderOverdrive { get; set; }

		[Outlet]
		AppKit.NSTableView tableViewCharacters { get; set; }

		[Outlet]
		AppKit.NSTextField txtAccuracy { get; set; }

		[Outlet]
		AppKit.NSTextField txtAttack { get; set; }

		[Outlet]
		AppKit.NSTextField txtAvoidance { get; set; }

		[Outlet]
		AppKit.NSTextField txtDefence { get; set; }

		[Outlet]
		AppKit.NSTextField txtHP { get; set; }

		[Outlet]
		AppKit.NSTextField txtLevel { get; set; }

		[Outlet]
		AppKit.NSTextField txtLuck { get; set; }

		[Outlet]
		AppKit.NSTextField txtMagic { get; set; }

		[Outlet]
		AppKit.NSTextField txtMagicDef { get; set; }

		[Outlet]
		AppKit.NSTextField txtMP { get; set; }

		[Outlet]
		AppKit.NSTextField txtSpeed { get; set; }

		[Action ("valueChanged:")]
		partial void valueChanged (AppKit.NSSlider sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (lblOverdrivePercent != null) {
				lblOverdrivePercent.Dispose ();
				lblOverdrivePercent = null;
			}

			if (sliderOverdrive != null) {
				sliderOverdrive.Dispose ();
				sliderOverdrive = null;
			}

			if (tableViewCharacters != null) {
				tableViewCharacters.Dispose ();
				tableViewCharacters = null;
			}

			if (txtAccuracy != null) {
				txtAccuracy.Dispose ();
				txtAccuracy = null;
			}

			if (txtAttack != null) {
				txtAttack.Dispose ();
				txtAttack = null;
			}

			if (txtAvoidance != null) {
				txtAvoidance.Dispose ();
				txtAvoidance = null;
			}

			if (txtDefence != null) {
				txtDefence.Dispose ();
				txtDefence = null;
			}

			if (txtHP != null) {
				txtHP.Dispose ();
				txtHP = null;
			}

			if (txtLevel != null) {
				txtLevel.Dispose ();
				txtLevel = null;
			}

			if (txtLuck != null) {
				txtLuck.Dispose ();
				txtLuck = null;
			}

			if (txtMagic != null) {
				txtMagic.Dispose ();
				txtMagic = null;
			}

			if (txtMagicDef != null) {
				txtMagicDef.Dispose ();
				txtMagicDef = null;
			}

			if (txtMP != null) {
				txtMP.Dispose ();
				txtMP = null;
			}

			if (txtSpeed != null) {
				txtSpeed.Dispose ();
				txtSpeed = null;
			}
		}
	}
}
