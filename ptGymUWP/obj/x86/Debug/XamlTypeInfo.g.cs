﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace ptGymUWP
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace ptGymUWP.ptGymUWP_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[26];
            _typeNameTable[0] = "ptGymUWP.CustomSplash";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "ptGymUWP.Funcionalidades.ClassClientFunc";
            _typeNameTable[4] = "ptGymUWP.Funcionalidades.ClientLocalidadeFunc";
            _typeNameTable[5] = "ptGymUWP.Funcionalidades.SalaAulaFunc";
            _typeNameTable[6] = "ptGymUWP.Funcionalidades.TreinadorAulaFunc";
            _typeNameTable[7] = "ptGymUWP.MainPage";
            _typeNameTable[8] = "ptGymUWP.Pages.ClassPage";
            _typeNameTable[9] = "ptGymUWP.Pages.ClientPage";
            _typeNameTable[10] = "ptGymUWP.Pages.CoachPage";
            _typeNameTable[11] = "ptGymUWP.Pages.MainPage1";
            _typeNameTable[12] = "ptGymUWP.Pages.RegistrationPage";
            _typeNameTable[13] = "ptGymUWP.Pages.RoomPage";
            _typeNameTable[14] = "ptGymUWP.Views.ClassContentDialog";
            _typeNameTable[15] = "Windows.UI.Xaml.Controls.ContentDialog";
            _typeNameTable[16] = "Windows.UI.Xaml.Controls.ContentControl";
            _typeNameTable[17] = "ptGymUWP.ViewModels.RoomViewModel";
            _typeNameTable[18] = "Object";
            _typeNameTable[19] = "ptGymUWP.ViewModels.CoachViewModel";
            _typeNameTable[20] = "ptGymUWP.Views.ClientContentDialog";
            _typeNameTable[21] = "ptGymUWP.ViewModels.ClientViewModel";
            _typeNameTable[22] = "ptGymUWP.Views.CoachContentDialog";
            _typeNameTable[23] = "ptGymUWP.Views.RegistrationContentDialog";
            _typeNameTable[24] = "ptGymUWP.ViewModels.ClassViewModel";
            _typeNameTable[25] = "ptGymUWP.Views.RoomContentDialog";

            _typeTable = new global::System.Type[26];
            _typeTable[0] = typeof(global::ptGymUWP.CustomSplash);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::ptGymUWP.Funcionalidades.ClassClientFunc);
            _typeTable[4] = typeof(global::ptGymUWP.Funcionalidades.ClientLocalidadeFunc);
            _typeTable[5] = typeof(global::ptGymUWP.Funcionalidades.SalaAulaFunc);
            _typeTable[6] = typeof(global::ptGymUWP.Funcionalidades.TreinadorAulaFunc);
            _typeTable[7] = typeof(global::ptGymUWP.MainPage);
            _typeTable[8] = typeof(global::ptGymUWP.Pages.ClassPage);
            _typeTable[9] = typeof(global::ptGymUWP.Pages.ClientPage);
            _typeTable[10] = typeof(global::ptGymUWP.Pages.CoachPage);
            _typeTable[11] = typeof(global::ptGymUWP.Pages.MainPage1);
            _typeTable[12] = typeof(global::ptGymUWP.Pages.RegistrationPage);
            _typeTable[13] = typeof(global::ptGymUWP.Pages.RoomPage);
            _typeTable[14] = typeof(global::ptGymUWP.Views.ClassContentDialog);
            _typeTable[15] = typeof(global::Windows.UI.Xaml.Controls.ContentDialog);
            _typeTable[16] = typeof(global::Windows.UI.Xaml.Controls.ContentControl);
            _typeTable[17] = typeof(global::ptGymUWP.ViewModels.RoomViewModel);
            _typeTable[18] = typeof(global::System.Object);
            _typeTable[19] = typeof(global::ptGymUWP.ViewModels.CoachViewModel);
            _typeTable[20] = typeof(global::ptGymUWP.Views.ClientContentDialog);
            _typeTable[21] = typeof(global::ptGymUWP.ViewModels.ClientViewModel);
            _typeTable[22] = typeof(global::ptGymUWP.Views.CoachContentDialog);
            _typeTable[23] = typeof(global::ptGymUWP.Views.RegistrationContentDialog);
            _typeTable[24] = typeof(global::ptGymUWP.ViewModels.ClassViewModel);
            _typeTable[25] = typeof(global::ptGymUWP.Views.RoomContentDialog);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_3_ClassClientFunc() { return new global::ptGymUWP.Funcionalidades.ClassClientFunc(); }
        private object Activate_4_ClientLocalidadeFunc() { return new global::ptGymUWP.Funcionalidades.ClientLocalidadeFunc(); }
        private object Activate_5_SalaAulaFunc() { return new global::ptGymUWP.Funcionalidades.SalaAulaFunc(); }
        private object Activate_6_TreinadorAulaFunc() { return new global::ptGymUWP.Funcionalidades.TreinadorAulaFunc(); }
        private object Activate_7_MainPage() { return new global::ptGymUWP.MainPage(); }
        private object Activate_8_ClassPage() { return new global::ptGymUWP.Pages.ClassPage(); }
        private object Activate_9_ClientPage() { return new global::ptGymUWP.Pages.ClientPage(); }
        private object Activate_10_CoachPage() { return new global::ptGymUWP.Pages.CoachPage(); }
        private object Activate_11_MainPage1() { return new global::ptGymUWP.Pages.MainPage1(); }
        private object Activate_12_RegistrationPage() { return new global::ptGymUWP.Pages.RegistrationPage(); }
        private object Activate_13_RoomPage() { return new global::ptGymUWP.Pages.RoomPage(); }
        private object Activate_14_ClassContentDialog() { return new global::ptGymUWP.Views.ClassContentDialog(); }
        private object Activate_17_RoomViewModel() { return new global::ptGymUWP.ViewModels.RoomViewModel(); }
        private object Activate_19_CoachViewModel() { return new global::ptGymUWP.ViewModels.CoachViewModel(); }
        private object Activate_20_ClientContentDialog() { return new global::ptGymUWP.Views.ClientContentDialog(); }
        private object Activate_21_ClientViewModel() { return new global::ptGymUWP.ViewModels.ClientViewModel(); }
        private object Activate_22_CoachContentDialog() { return new global::ptGymUWP.Views.CoachContentDialog(); }
        private object Activate_23_RegistrationContentDialog() { return new global::ptGymUWP.Views.RegistrationContentDialog(); }
        private object Activate_24_ClassViewModel() { return new global::ptGymUWP.ViewModels.ClassViewModel(); }
        private object Activate_25_RoomContentDialog() { return new global::ptGymUWP.Views.RoomContentDialog(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  ptGymUWP.CustomSplash
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  ptGymUWP.Funcionalidades.ClassClientFunc
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_ClassClientFunc;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  ptGymUWP.Funcionalidades.ClientLocalidadeFunc
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_4_ClientLocalidadeFunc;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  ptGymUWP.Funcionalidades.SalaAulaFunc
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_5_SalaAulaFunc;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  ptGymUWP.Funcionalidades.TreinadorAulaFunc
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_6_TreinadorAulaFunc;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  ptGymUWP.MainPage
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  ptGymUWP.Pages.ClassPage
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_ClassPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  ptGymUWP.Pages.ClientPage
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_ClientPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  ptGymUWP.Pages.CoachPage
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_CoachPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  ptGymUWP.Pages.MainPage1
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_MainPage1;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  ptGymUWP.Pages.RegistrationPage
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_RegistrationPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  ptGymUWP.Pages.RoomPage
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_RoomPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  ptGymUWP.Views.ClassContentDialog
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ContentDialog"));
                userType.Activator = Activate_14_ClassContentDialog;
                userType.AddMemberName("RoomViewModel");
                userType.AddMemberName("CoachViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  Windows.UI.Xaml.Controls.ContentDialog
                xamlType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 16:   //  Windows.UI.Xaml.Controls.ContentControl
                xamlType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 17:   //  ptGymUWP.ViewModels.RoomViewModel
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 18:   //  Object
                xamlType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 19:   //  ptGymUWP.ViewModels.CoachViewModel
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 20:   //  ptGymUWP.Views.ClientContentDialog
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ContentDialog"));
                userType.Activator = Activate_20_ClientContentDialog;
                userType.AddMemberName("ClientViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 21:   //  ptGymUWP.ViewModels.ClientViewModel
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 22:   //  ptGymUWP.Views.CoachContentDialog
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ContentDialog"));
                userType.Activator = Activate_22_CoachContentDialog;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 23:   //  ptGymUWP.Views.RegistrationContentDialog
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ContentDialog"));
                userType.Activator = Activate_23_RegistrationContentDialog;
                userType.AddMemberName("ClientViewModel");
                userType.AddMemberName("ClassViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 24:   //  ptGymUWP.ViewModels.ClassViewModel
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 25:   //  ptGymUWP.Views.RoomContentDialog
                userType = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ContentDialog"));
                userType.Activator = Activate_25_RoomContentDialog;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_ClassContentDialog_RoomViewModel(object instance)
        {
            var that = (global::ptGymUWP.Views.ClassContentDialog)instance;
            return that.RoomViewModel;
        }
        private void set_0_ClassContentDialog_RoomViewModel(object instance, object Value)
        {
            var that = (global::ptGymUWP.Views.ClassContentDialog)instance;
            that.RoomViewModel = (global::ptGymUWP.ViewModels.RoomViewModel)Value;
        }
        private object get_1_ClassContentDialog_CoachViewModel(object instance)
        {
            var that = (global::ptGymUWP.Views.ClassContentDialog)instance;
            return that.CoachViewModel;
        }
        private void set_1_ClassContentDialog_CoachViewModel(object instance, object Value)
        {
            var that = (global::ptGymUWP.Views.ClassContentDialog)instance;
            that.CoachViewModel = (global::ptGymUWP.ViewModels.CoachViewModel)Value;
        }
        private object get_2_ClientContentDialog_ClientViewModel(object instance)
        {
            var that = (global::ptGymUWP.Views.ClientContentDialog)instance;
            return that.ClientViewModel;
        }
        private void set_2_ClientContentDialog_ClientViewModel(object instance, object Value)
        {
            var that = (global::ptGymUWP.Views.ClientContentDialog)instance;
            that.ClientViewModel = (global::ptGymUWP.ViewModels.ClientViewModel)Value;
        }
        private object get_3_RegistrationContentDialog_ClientViewModel(object instance)
        {
            var that = (global::ptGymUWP.Views.RegistrationContentDialog)instance;
            return that.ClientViewModel;
        }
        private void set_3_RegistrationContentDialog_ClientViewModel(object instance, object Value)
        {
            var that = (global::ptGymUWP.Views.RegistrationContentDialog)instance;
            that.ClientViewModel = (global::ptGymUWP.ViewModels.ClientViewModel)Value;
        }
        private object get_4_RegistrationContentDialog_ClassViewModel(object instance)
        {
            var that = (global::ptGymUWP.Views.RegistrationContentDialog)instance;
            return that.ClassViewModel;
        }
        private void set_4_RegistrationContentDialog_ClassViewModel(object instance, object Value)
        {
            var that = (global::ptGymUWP.Views.RegistrationContentDialog)instance;
            that.ClassViewModel = (global::ptGymUWP.ViewModels.ClassViewModel)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlMember xamlMember = null;
            global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "ptGymUWP.Views.ClassContentDialog.RoomViewModel":
                userType = (global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ptGymUWP.Views.ClassContentDialog");
                xamlMember = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlMember(this, "RoomViewModel", "ptGymUWP.ViewModels.RoomViewModel");
                xamlMember.Getter = get_0_ClassContentDialog_RoomViewModel;
                xamlMember.Setter = set_0_ClassContentDialog_RoomViewModel;
                break;
            case "ptGymUWP.Views.ClassContentDialog.CoachViewModel":
                userType = (global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ptGymUWP.Views.ClassContentDialog");
                xamlMember = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlMember(this, "CoachViewModel", "ptGymUWP.ViewModels.CoachViewModel");
                xamlMember.Getter = get_1_ClassContentDialog_CoachViewModel;
                xamlMember.Setter = set_1_ClassContentDialog_CoachViewModel;
                break;
            case "ptGymUWP.Views.ClientContentDialog.ClientViewModel":
                userType = (global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ptGymUWP.Views.ClientContentDialog");
                xamlMember = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlMember(this, "ClientViewModel", "ptGymUWP.ViewModels.ClientViewModel");
                xamlMember.Getter = get_2_ClientContentDialog_ClientViewModel;
                xamlMember.Setter = set_2_ClientContentDialog_ClientViewModel;
                break;
            case "ptGymUWP.Views.RegistrationContentDialog.ClientViewModel":
                userType = (global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ptGymUWP.Views.RegistrationContentDialog");
                xamlMember = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlMember(this, "ClientViewModel", "ptGymUWP.ViewModels.ClientViewModel");
                xamlMember.Getter = get_3_RegistrationContentDialog_ClientViewModel;
                xamlMember.Setter = set_3_RegistrationContentDialog_ClientViewModel;
                break;
            case "ptGymUWP.Views.RegistrationContentDialog.ClassViewModel":
                userType = (global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ptGymUWP.Views.RegistrationContentDialog");
                xamlMember = new global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlMember(this, "ClassViewModel", "ptGymUWP.ViewModels.ClassViewModel");
                xamlMember.Getter = get_4_RegistrationContentDialog_ClassViewModel;
                xamlMember.Setter = set_4_RegistrationContentDialog_ClassViewModel;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlSystemBaseType
    {
        global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::ptGymUWP.ptGymUWP_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}
