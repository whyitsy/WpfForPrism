using System.Windows;
using WpfForPrism.Views;

namespace WpfForPrism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        /// <summary>
        /// 返回项目的启动页。从容器中获取
        /// </summary>
        /// <returns></returns>
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        /// <summary>
        /// 在这里注册服务到容器中。
        /// </summary>
        /// <param name="containerRegistry"></param>
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<UCA>("uca");
            containerRegistry.RegisterForNavigation<UCB>("ucb");
            containerRegistry.RegisterForNavigation<UCC>("ucc");
        }
    }

}
