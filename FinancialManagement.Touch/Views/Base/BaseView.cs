using Foundation;
using MvvmCross.iOS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace FinancialManagement.Touch.Views.Base
{
    public abstract class BaseView : MvxViewController
    {
        public bool IsVisible { get; private set; }

        public override void ViewDidLoad()
        {
            View = new UIView { BackgroundColor = UIColor.White };
            View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
            {
                HideKeyboard();
            }));

            View.MultipleTouchEnabled = false;

            NavigationController.NavigationBarHidden = true;

            // ios7 layout
            if (RespondsToSelector(new ObjCRuntime.Selector("edgesForExtendedLayout")))
            {
                EdgesForExtendedLayout = UIRectEdge.None;
            }

            base.ViewDidLoad();

            InitView();
            CreateBinding();
        }

        public override void WillRotate(UIInterfaceOrientation toInterfaceOrientation, double duration)
        {
            //ResolutionHelper.RefreshStaticVariable();

            base.WillRotate(toInterfaceOrientation, duration);
        }

        private NSObject _willResignActiveNotificationObserver;
        private NSObject _didBecomeActiveNotificationObserver;

        public override void ViewWillAppear(bool animated)
        {
            IsVisible = true;

            base.ViewWillAppear(animated);

            _willResignActiveNotificationObserver = NSNotificationCenter.DefaultCenter.AddObserver(UIKeyboard.WillHideNotification, OnWillHideKeyboard);
            _didBecomeActiveNotificationObserver = NSNotificationCenter.DefaultCenter.AddObserver(UIKeyboard.WillShowNotification, OnWillShowKeyboard);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            if (_willResignActiveNotificationObserver != null)
            {
                NSNotificationCenter.DefaultCenter.RemoveObserver(_willResignActiveNotificationObserver);
            }

            if (_didBecomeActiveNotificationObserver != null)
            {
                NSNotificationCenter.DefaultCenter.RemoveObserver(_didBecomeActiveNotificationObserver);
            }

            IsVisible = false;
        }

        protected abstract void InitView();

        protected abstract void CreateBinding();

        protected virtual void OnWillShowKeyboard(NSNotification notification)
        {
        }

        protected virtual void OnWillHideKeyboard(NSNotification notification)
        {
        }

        protected float ToY(float y)
        {
            //return (float)(y + ResolutionHelper.StatusHeight);
            return 0f;
        }

        protected void HideKeyboard()
        {
            View.EndEditing(true);
        }
    }

}