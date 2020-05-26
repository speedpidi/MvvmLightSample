namespace MvvmLight.Logic
{
    using CommonServiceLocator;
    using GalaSoft.MvvmLight.Ioc;

    public class ViewModelLocator
    {
        #region ctor

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //if (ViewModelBase.IsInDesignModeStatic)
            //{
            //    // Create design time view services and models
            //    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            //}
            //else
            //{
            //    // Create run time view services and models
            //    SimpleIoc.Default.Register<IDataService, DataService>();
            //}

            SimpleIoc.Default.Register<MainViewModel>();
        }

        #endregion

        #region properties

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        #endregion

        #region methods

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }

        #endregion
    }
}