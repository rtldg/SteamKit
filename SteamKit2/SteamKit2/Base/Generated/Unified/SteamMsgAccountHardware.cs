// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_accounthardware.steamclient.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Unified.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_RegisterSteamController_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string serial_number
        {
            get { return __pbn__serial_number ?? ""; }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private string __pbn__serial_number;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string controller_code
        {
            get { return __pbn__controller_code ?? ""; }
            set { __pbn__controller_code = value; }
        }
        public bool ShouldSerializecontroller_code() => __pbn__controller_code != null;
        public void Resetcontroller_code() => __pbn__controller_code = null;
        private string __pbn__controller_code;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_RegisterSteamController_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_CompleteSteamControllerRegistration_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string serial_number
        {
            get { return __pbn__serial_number ?? ""; }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private string __pbn__serial_number;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string controller_code
        {
            get { return __pbn__controller_code ?? ""; }
            set { __pbn__controller_code = value; }
        }
        public bool ShouldSerializecontroller_code() => __pbn__controller_code != null;
        public void Resetcontroller_code() => __pbn__controller_code = null;
        private string __pbn__controller_code;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_CompleteSteamControllerRegistration_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_QueryAccountsRegisteredToSerial_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string serial_number
        {
            get { return __pbn__serial_number ?? ""; }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private string __pbn__serial_number;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string controller_code
        {
            get { return __pbn__controller_code ?? ""; }
            set { __pbn__controller_code = value; }
        }
        public bool ShouldSerializecontroller_code() => __pbn__controller_code != null;
        public void Resetcontroller_code() => __pbn__controller_code = null;
        private string __pbn__controller_code;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_QueryAccountsRegisteredToSerial_Accounts : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint accountid
        {
            get { return __pbn__accountid.GetValueOrDefault(); }
            set { __pbn__accountid = value; }
        }
        public bool ShouldSerializeaccountid() => __pbn__accountid != null;
        public void Resetaccountid() => __pbn__accountid = null;
        private uint? __pbn__accountid;

        [global::ProtoBuf.ProtoMember(2)]
        public bool registration_complete
        {
            get { return __pbn__registration_complete.GetValueOrDefault(); }
            set { __pbn__registration_complete = value; }
        }
        public bool ShouldSerializeregistration_complete() => __pbn__registration_complete != null;
        public void Resetregistration_complete() => __pbn__registration_complete = null;
        private bool? __pbn__registration_complete;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_QueryAccountsRegisteredToSerial_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CAccountHardware_QueryAccountsRegisteredToSerial_Accounts> accounts { get; } = new global::System.Collections.Generic.List<CAccountHardware_QueryAccountsRegisteredToSerial_Accounts>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_SteamControllerSetConfig_ControllerConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string appidorname
        {
            get { return __pbn__appidorname ?? ""; }
            set { __pbn__appidorname = value; }
        }
        public bool ShouldSerializeappidorname() => __pbn__appidorname != null;
        public void Resetappidorname() => __pbn__appidorname = null;
        private string __pbn__appidorname;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong publishedfileid
        {
            get { return __pbn__publishedfileid.GetValueOrDefault(); }
            set { __pbn__publishedfileid = value; }
        }
        public bool ShouldSerializepublishedfileid() => __pbn__publishedfileid != null;
        public void Resetpublishedfileid() => __pbn__publishedfileid = null;
        private ulong? __pbn__publishedfileid;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string templatename
        {
            get { return __pbn__templatename ?? ""; }
            set { __pbn__templatename = value; }
        }
        public bool ShouldSerializetemplatename() => __pbn__templatename != null;
        public void Resettemplatename() => __pbn__templatename = null;
        private string __pbn__templatename;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_SteamControllerSetConfig_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string serial_number
        {
            get { return __pbn__serial_number ?? ""; }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private string __pbn__serial_number;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string controller_code
        {
            get { return __pbn__controller_code ?? ""; }
            set { __pbn__controller_code = value; }
        }
        public bool ShouldSerializecontroller_code() => __pbn__controller_code != null;
        public void Resetcontroller_code() => __pbn__controller_code = null;
        private string __pbn__controller_code;

        [global::ProtoBuf.ProtoMember(3)]
        public uint accountid
        {
            get { return __pbn__accountid.GetValueOrDefault(); }
            set { __pbn__accountid = value; }
        }
        public bool ShouldSerializeaccountid() => __pbn__accountid != null;
        public void Resetaccountid() => __pbn__accountid = null;
        private uint? __pbn__accountid;

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<CAccountHardware_SteamControllerSetConfig_ControllerConfig> configurations { get; } = new global::System.Collections.Generic.List<CAccountHardware_SteamControllerSetConfig_ControllerConfig>();

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(2)]
        public int controller_type
        {
            get { return __pbn__controller_type ?? 2; }
            set { __pbn__controller_type = value; }
        }
        public bool ShouldSerializecontroller_type() => __pbn__controller_type != null;
        public void Resetcontroller_type() => __pbn__controller_type = null;
        private int? __pbn__controller_type;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool only_for_this_serial
        {
            get { return __pbn__only_for_this_serial ?? false; }
            set { __pbn__only_for_this_serial = value; }
        }
        public bool ShouldSerializeonly_for_this_serial() => __pbn__only_for_this_serial != null;
        public void Resetonly_for_this_serial() => __pbn__only_for_this_serial = null;
        private bool? __pbn__only_for_this_serial;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_SteamControllerSetConfig_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_SteamControllerGetConfig_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string serial_number
        {
            get { return __pbn__serial_number ?? ""; }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private string __pbn__serial_number;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string controller_code
        {
            get { return __pbn__controller_code ?? ""; }
            set { __pbn__controller_code = value; }
        }
        public bool ShouldSerializecontroller_code() => __pbn__controller_code != null;
        public void Resetcontroller_code() => __pbn__controller_code = null;
        private string __pbn__controller_code;

        [global::ProtoBuf.ProtoMember(3)]
        public uint accountid
        {
            get { return __pbn__accountid.GetValueOrDefault(); }
            set { __pbn__accountid = value; }
        }
        public bool ShouldSerializeaccountid() => __pbn__accountid != null;
        public void Resetaccountid() => __pbn__accountid = null;
        private uint? __pbn__accountid;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string appidorname
        {
            get { return __pbn__appidorname ?? ""; }
            set { __pbn__appidorname = value; }
        }
        public bool ShouldSerializeappidorname() => __pbn__appidorname != null;
        public void Resetappidorname() => __pbn__appidorname = null;
        private string __pbn__appidorname;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(2)]
        public int controller_type
        {
            get { return __pbn__controller_type ?? 2; }
            set { __pbn__controller_type = value; }
        }
        public bool ShouldSerializecontroller_type() => __pbn__controller_type != null;
        public void Resetcontroller_type() => __pbn__controller_type = null;
        private int? __pbn__controller_type;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool only_for_this_serial
        {
            get { return __pbn__only_for_this_serial ?? false; }
            set { __pbn__only_for_this_serial = value; }
        }
        public bool ShouldSerializeonly_for_this_serial() => __pbn__only_for_this_serial != null;
        public void Resetonly_for_this_serial() => __pbn__only_for_this_serial = null;
        private bool? __pbn__only_for_this_serial;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_SteamControllerGetConfig_ControllerConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string appidorname
        {
            get { return __pbn__appidorname ?? ""; }
            set { __pbn__appidorname = value; }
        }
        public bool ShouldSerializeappidorname() => __pbn__appidorname != null;
        public void Resetappidorname() => __pbn__appidorname = null;
        private string __pbn__appidorname;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong publishedfileid
        {
            get { return __pbn__publishedfileid.GetValueOrDefault(); }
            set { __pbn__publishedfileid = value; }
        }
        public bool ShouldSerializepublishedfileid() => __pbn__publishedfileid != null;
        public void Resetpublishedfileid() => __pbn__publishedfileid = null;
        private ulong? __pbn__publishedfileid;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string templatename
        {
            get { return __pbn__templatename ?? ""; }
            set { __pbn__templatename = value; }
        }
        public bool ShouldSerializetemplatename() => __pbn__templatename != null;
        public void Resettemplatename() => __pbn__templatename = null;
        private string __pbn__templatename;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string serial_number
        {
            get { return __pbn__serial_number ?? ""; }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private string __pbn__serial_number;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_SteamControllerGetConfig_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CAccountHardware_SteamControllerGetConfig_ControllerConfig> configurations { get; } = new global::System.Collections.Generic.List<CAccountHardware_SteamControllerGetConfig_ControllerConfig>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_DeRegisterSteamController_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string serial_number
        {
            get { return __pbn__serial_number ?? ""; }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private string __pbn__serial_number;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string controller_code
        {
            get { return __pbn__controller_code ?? ""; }
            set { __pbn__controller_code = value; }
        }
        public bool ShouldSerializecontroller_code() => __pbn__controller_code != null;
        public void Resetcontroller_code() => __pbn__controller_code = null;
        private string __pbn__controller_code;

        [global::ProtoBuf.ProtoMember(3)]
        public uint accountid
        {
            get { return __pbn__accountid.GetValueOrDefault(); }
            set { __pbn__accountid = value; }
        }
        public bool ShouldSerializeaccountid() => __pbn__accountid != null;
        public void Resetaccountid() => __pbn__accountid = null;
        private uint? __pbn__accountid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_DeRegisterSteamController_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_SetPersonalizationFile_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string serial_number
        {
            get { return __pbn__serial_number ?? ""; }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private string __pbn__serial_number;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong publishedfileid
        {
            get { return __pbn__publishedfileid.GetValueOrDefault(); }
            set { __pbn__publishedfileid = value; }
        }
        public bool ShouldSerializepublishedfileid() => __pbn__publishedfileid != null;
        public void Resetpublishedfileid() => __pbn__publishedfileid = null;
        private ulong? __pbn__publishedfileid;

        [global::ProtoBuf.ProtoMember(3)]
        public uint accountid
        {
            get { return __pbn__accountid.GetValueOrDefault(); }
            set { __pbn__accountid = value; }
        }
        public bool ShouldSerializeaccountid() => __pbn__accountid != null;
        public void Resetaccountid() => __pbn__accountid = null;
        private uint? __pbn__accountid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_SetPersonalizationFile_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_GetPersonalizationFile_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string serial_number
        {
            get { return __pbn__serial_number ?? ""; }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private string __pbn__serial_number;

        [global::ProtoBuf.ProtoMember(2)]
        public uint accountid
        {
            get { return __pbn__accountid.GetValueOrDefault(); }
            set { __pbn__accountid = value; }
        }
        public bool ShouldSerializeaccountid() => __pbn__accountid != null;
        public void Resetaccountid() => __pbn__accountid = null;
        private uint? __pbn__accountid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_GetPersonalizationFile_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong publishedfileid
        {
            get { return __pbn__publishedfileid.GetValueOrDefault(); }
            set { __pbn__publishedfileid = value; }
        }
        public bool ShouldSerializepublishedfileid() => __pbn__publishedfileid != null;
        public void Resetpublishedfileid() => __pbn__publishedfileid = null;
        private ulong? __pbn__publishedfileid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_VRCompatibilityCheck_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string product_name
        {
            get { return __pbn__product_name ?? ""; }
            set { __pbn__product_name = value; }
        }
        public bool ShouldSerializeproduct_name() => __pbn__product_name != null;
        public void Resetproduct_name() => __pbn__product_name = null;
        private string __pbn__product_name;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<Pair> values { get; } = new global::System.Collections.Generic.List<Pair>();

        [global::ProtoBuf.ProtoContract()]
        public partial class Pair : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            [global::System.ComponentModel.DefaultValue("")]
            public string key
            {
                get { return __pbn__key ?? ""; }
                set { __pbn__key = value; }
            }
            public bool ShouldSerializekey() => __pbn__key != null;
            public void Resetkey() => __pbn__key = null;
            private string __pbn__key;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string value
            {
                get { return __pbn__value ?? ""; }
                set { __pbn__value = value; }
            }
            public bool ShouldSerializevalue() => __pbn__value != null;
            public void Resetvalue() => __pbn__value = null;
            private string __pbn__value;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_VRCompatibilityCheck_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<Pair> values { get; } = new global::System.Collections.Generic.List<Pair>();

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<ComponentDisplay> components { get; } = new global::System.Collections.Generic.List<ComponentDisplay>();

        [global::ProtoBuf.ProtoContract()]
        public partial class Pair : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            [global::System.ComponentModel.DefaultValue("")]
            public string key
            {
                get { return __pbn__key ?? ""; }
                set { __pbn__key = value; }
            }
            public bool ShouldSerializekey() => __pbn__key != null;
            public void Resetkey() => __pbn__key = null;
            private string __pbn__key;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string value
            {
                get { return __pbn__value ?? ""; }
                set { __pbn__value = value; }
            }
            public bool ShouldSerializevalue() => __pbn__value != null;
            public void Resetvalue() => __pbn__value = null;
            private string __pbn__value;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class ComponentDisplay : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            [global::System.ComponentModel.DefaultValue("")]
            public string name
            {
                get { return __pbn__name ?? ""; }
                set { __pbn__name = value; }
            }
            public bool ShouldSerializename() => __pbn__name != null;
            public void Resetname() => __pbn__name = null;
            private string __pbn__name;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string image
            {
                get { return __pbn__image ?? ""; }
                set { __pbn__image = value; }
            }
            public bool ShouldSerializeimage() => __pbn__image != null;
            public void Resetimage() => __pbn__image = null;
            private string __pbn__image;

            [global::ProtoBuf.ProtoMember(3)]
            [global::System.ComponentModel.DefaultValue("")]
            public string value
            {
                get { return __pbn__value ?? ""; }
                set { __pbn__value = value; }
            }
            public bool ShouldSerializevalue() => __pbn__value != null;
            public void Resetvalue() => __pbn__value = null;
            private string __pbn__value;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_RegisterValveIndexComponent_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string serial_number
        {
            get { return __pbn__serial_number ?? ""; }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private string __pbn__serial_number;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string manufacturer_serial_number
        {
            get { return __pbn__manufacturer_serial_number ?? ""; }
            set { __pbn__manufacturer_serial_number = value; }
        }
        public bool ShouldSerializemanufacturer_serial_number() => __pbn__manufacturer_serial_number != null;
        public void Resetmanufacturer_serial_number() => __pbn__manufacturer_serial_number = null;
        private string __pbn__manufacturer_serial_number;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string component_code
        {
            get { return __pbn__component_code ?? ""; }
            set { __pbn__component_code = value; }
        }
        public bool ShouldSerializecomponent_code() => __pbn__component_code != null;
        public void Resetcomponent_code() => __pbn__component_code = null;
        private string __pbn__component_code;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(EValveIndexComponent.k_EValveIndexComponentUnknown)]
        public EValveIndexComponent component_type
        {
            get { return __pbn__component_type ?? EValveIndexComponent.k_EValveIndexComponentUnknown; }
            set { __pbn__component_type = value; }
        }
        public bool ShouldSerializecomponent_type() => __pbn__component_type != null;
        public void Resetcomponent_type() => __pbn__component_type = null;
        private EValveIndexComponent? __pbn__component_type;

        [global::ProtoBuf.ProtoMember(5)]
        public int estimated_time_registered
        {
            get { return __pbn__estimated_time_registered.GetValueOrDefault(); }
            set { __pbn__estimated_time_registered = value; }
        }
        public bool ShouldSerializeestimated_time_registered() => __pbn__estimated_time_registered != null;
        public void Resetestimated_time_registered() => __pbn__estimated_time_registered = null;
        private int? __pbn__estimated_time_registered;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountHardware_RegisterValveIndexComponent_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public enum EValveIndexComponent
    {
        k_EValveIndexComponentUnknown = 0,
        k_EValveIndexComponentHMD = 1,
        k_EValveIndexComponentLeftKnuckle = 2,
        k_EValveIndexComponentRightKnuckle = 3,
    }

    public interface IAccountHardware
    {
        CAccountHardware_RegisterSteamController_Response RegisterSteamController(CAccountHardware_RegisterSteamController_Request request);
        CAccountHardware_CompleteSteamControllerRegistration_Response CompleteSteamControllerRegistration(CAccountHardware_CompleteSteamControllerRegistration_Request request);
        CAccountHardware_QueryAccountsRegisteredToSerial_Response QueryAccountsRegisteredToController(CAccountHardware_QueryAccountsRegisteredToSerial_Request request);
        CAccountHardware_SteamControllerSetConfig_Response SetDesiredControllerConfigForApp(CAccountHardware_SteamControllerSetConfig_Request request);
        CAccountHardware_SteamControllerGetConfig_Response GetDesiredControllerConfigForApp(CAccountHardware_SteamControllerGetConfig_Request request);
        CAccountHardware_DeRegisterSteamController_Response DeRegisterSteamController(CAccountHardware_DeRegisterSteamController_Request request);
        CAccountHardware_SetPersonalizationFile_Response SetControllerPersonalizationFile(CAccountHardware_SetPersonalizationFile_Request request);
        CAccountHardware_GetPersonalizationFile_Response GetControllerPersonalizationFile(CAccountHardware_GetPersonalizationFile_Request request);
        CAccountHardware_VRCompatibilityCheck_Response VRCompatibilityCheck(CAccountHardware_VRCompatibilityCheck_Request request);
        CAccountHardware_RegisterValveIndexComponent_Response RegisterValveIndexComponent(CAccountHardware_RegisterValveIndexComponent_Request request);
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
