﻿#pragma checksum "C:\Users\paulo\OneDrive\Documentos\Visual Studio 2015\Projects\ptGym\ptGymUWP\Views\RoomContentDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "72A36B88095483ED4D705DEBA0B470DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ptGymUWP.Views
{
    partial class RoomContentDialog : 
        global::Windows.UI.Xaml.Controls.ContentDialog, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class RoomContentDialog_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IRoomContentDialog_Bindings
        {
            private global::ptGymUWP.Views.RoomContentDialog dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBox obj2;
            private global::Windows.UI.Xaml.Controls.TextBox obj3;

            private RoomContentDialog_obj1_BindingsTracking bindingsTracking;

            public RoomContentDialog_obj1_Bindings()
            {
                this.bindingsTracking = new RoomContentDialog_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj2).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.RoomViewModel.Room.Capacity = (global::System.Int64) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Int64), (this.obj2).Text);
                                }
                            };
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj3).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.RoomViewModel.Room.Name = (this.obj3).Text;
                                }
                            };
                        break;
                    default:
                        break;
                }
            }

            // IRoomContentDialog_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // RoomContentDialog_obj1_Bindings

            public void SetDataRoot(global::ptGymUWP.Views.RoomContentDialog newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ptGymUWP.Views.RoomContentDialog obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_RoomViewModel(obj.RoomViewModel, phase);
                    }
                }
            }
            private void Update_RoomViewModel(global::ptGymUWP.ViewModels.RoomViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_RoomViewModel_Room(obj.Room, phase);
                    }
                }
            }
            private void Update_RoomViewModel_Room(global::ptGym_Dal_BL.BL.Room obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_RoomViewModel_Room(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_RoomViewModel_Room_Capacity(obj.Capacity, phase);
                        this.Update_RoomViewModel_Room_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_RoomViewModel_Room_Capacity(global::System.Int64 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj2, obj.ToString(), null);
                }
            }
            private void Update_RoomViewModel_Room_Name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj3, obj, null);
                }
            }

            private class RoomContentDialog_obj1_BindingsTracking
            {
                global::System.WeakReference<RoomContentDialog_obj1_Bindings> WeakRefToBindingObj; 

                public RoomContentDialog_obj1_BindingsTracking(RoomContentDialog_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<RoomContentDialog_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_RoomViewModel_Room(null);
                }

                public void PropertyChanged_RoomViewModel_Room(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    RoomContentDialog_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::ptGym_Dal_BL.BL.Room obj = sender as global::ptGym_Dal_BL.BL.Room;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_RoomViewModel_Room_Capacity(obj.Capacity, DATA_CHANGED);
                                    bindings.Update_RoomViewModel_Room_Name(obj.Name, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Capacity":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_RoomViewModel_Room_Capacity(obj.Capacity, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Name":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_RoomViewModel_Room_Name(obj.Name, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::ptGym_Dal_BL.BL.Room cache_RoomViewModel_Room = null;
                public void UpdateChildListeners_RoomViewModel_Room(global::ptGym_Dal_BL.BL.Room obj)
                {
                    if (obj != cache_RoomViewModel_Room)
                    {
                        if (cache_RoomViewModel_Room != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_RoomViewModel_Room).PropertyChanged -= PropertyChanged_RoomViewModel_Room;
                            cache_RoomViewModel_Room = null;
                        }
                        if (obj != null)
                        {
                            cache_RoomViewModel_Room = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_RoomViewModel_Room;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.ContentDialog element1 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                    #line 12 "..\..\..\Views\RoomContentDialog.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).PrimaryButtonClick += this.ContentDialog_PrimaryButtonClick;
                    #line 13 "..\..\..\Views\RoomContentDialog.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).SecondaryButtonClick += this.ContentDialog_SecondaryButtonClick;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.ContentDialog element1 = (global::Windows.UI.Xaml.Controls.ContentDialog)target;
                    RoomContentDialog_obj1_Bindings bindings = new RoomContentDialog_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
