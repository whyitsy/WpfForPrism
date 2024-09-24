using System.Windows.Controls;
using WpfForPrism.Views;

namespace WpfForPrism.ViewModels;

public class MainWindowViewModel : BindableBase
{
    /// <summary>
    /// Prism的区域管理
    /// </summary>
    private readonly IRegionManager _regionManager;
    public DelegateCommand<string> ChangeContentCommand { get; set; }

    public MainWindowViewModel(IRegionManager regionManager)
    {
        _regionManager = regionManager;
        ChangeContentCommand = new DelegateCommand<string>(ChangeShowContent);
    }

    private void ChangeShowContent(string uc2Change)
    {
        //ShowContent = uc2Change switch
        //{
        //    "uca" => new UCA(),
        //    "ucb" => new UCB(),
        //    "ucc" => new UCC(),
        //    _ => ShowContent
        //};

        // 使用区域管理为指定的区域注入内容
        _regionManager.Regions["ContentRegion"].RequestNavigate(uc2Change);
    }


    private UserControl _showContent;

    public UserControl ShowContent
    {
        get => _showContent;
        set
        {
            _showContent = value;
            RaisePropertyChanged();
        }
    }

}