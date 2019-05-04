using System;
using AppKit;
using FF10.Core.Data;
using FF10.Core.ViewModels;
using FF10.Mac.DataSources;
using Foundation;

namespace FF10.Mac
{
    public partial class ViewController : NSViewController
    {
        MainWindowViewModel _viewModel;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            _viewModel = new MainWindowViewModel();

            base.ViewDidLoad();
        }

        void DisplayCharacterStats(int characterIndex)
        {
            txtHP.IntValue = (int)_viewModel.Party[characterIndex].HP;
            txtMP.IntValue = (int)_viewModel.Party[characterIndex].MP;
            txtLuck.IntValue = (int)_viewModel.Party[characterIndex].Luck;
            txtLevel.IntValue = (int)_viewModel.Party[characterIndex].Lv;
            txtMagic.IntValue = (int)_viewModel.Party[characterIndex].Magic;
            txtSpeed.IntValue = (int)_viewModel.Party[characterIndex].Speed;
            txtAttack.IntValue = (int)_viewModel.Party[characterIndex].Attack;
            txtDefence.IntValue = (int)_viewModel.Party[characterIndex].Defense;
            txtAccuracy.IntValue = (int)_viewModel.Party[characterIndex].Hit;
            txtMagicDef.IntValue = (int)_viewModel.Party[characterIndex].MagicGuard;
            txtAvoidance.IntValue = (int)_viewModel.Party[characterIndex].Avoidance;
        }

        void SetCharacterListValues()
        {
            // Create the Character Table Data Source and populate it
            var dataSource = new CharacterDataSource();
            dataSource.Characters = Data.CharacterData;

            // Populate the Character Table
            tableViewCharacters.Source = dataSource;
            tableViewCharacters.Delegate = new CharacterTableDelegate(dataSource);

            tableViewCharacters.ReloadData();
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            SetCharacterListValues();
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
