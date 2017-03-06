using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace FinancialManagement.Touch.Views.Base
{
    public class IOSPresenter : MvxIosViewPresenter
    {
        //private MasterView _masterView;
        public IOSPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {
        }

        //public void RegisterMasterController(MasterView masterView)
        //{
        //    _masterView = masterView;
        //}

        public override void Show(MvxViewModelRequest request)
        {
            //if (request.ViewModelType.IsSubclassOf(typeof(PopupViewModel)))
            //{
            //    base.Show(request);
            //}
            //else
            //{
            //    var viewController = (UIViewController)Mvx.Resolve<IMvxTouchViewCreator>().CreateView(request);

            //    _masterView.AddChildViewController(viewController);
            //    _masterView.View.InsertSubviewBelow(viewController.View, _masterView.TitleBar);
            //    _masterView.View.AddConstraints(new NSLayoutConstraint[]
            //    {
            //        NSLayoutConstraint.Create(viewController.View, NSLayoutAttribute.Top, NSLayoutRelation.Equal, _masterView.TitleBar, NSLayoutAttribute.Bottom, 1, 0),
            //        NSLayoutConstraint.Create(viewController.View, NSLayoutAttribute.Right, NSLayoutRelation.Equal, _masterView.View, NSLayoutAttribute.Right, 1, 0),
            //        NSLayoutConstraint.Create(viewController.View, NSLayoutAttribute.Left, NSLayoutRelation.Equal, _masterView.View, NSLayoutAttribute.Left, 1, 0),
            //        NSLayoutConstraint.Create(viewController.View, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, _masterView.View, NSLayoutAttribute.Bottom, 1, 0)
            //    });

            //    viewController.View.TranslatesAutoresizingMaskIntoConstraints = false;
            //}
        }

        public override void Close(IMvxViewModel toClose)
        {
            //if (toClose is PopupViewModel)
            //{
            //    base.Close(toClose);
            //}
            //else
            //{
            //    var viewController = (MvxViewController)_masterView.ChildViewControllers
            //        .FirstOrDefault(x => (x as MvxViewController).ViewModel == toClose);
            //    viewController.BindingContext.ClearAllBindings();
            //    viewController.ViewModel = null;
            //    viewController.View.RemoveFromSuperview();
            //    viewController.ViewWillUnload();
            //    viewController.RemoveFromParentViewController();
            //    viewController.Dispose();
            //}
        }
    }
}