namespace Com.Facebook.Stetho.Inspector.Elements
{
    partial class DescriptorMap
    {
        IDescriptorRegistrar IDescriptorRegistrar.RegisterDescriptor(Java.Lang.Class p0, Elements.Descriptor p1)
        {
            return RegisterDescriptor(p0, p1);
        }
    }
}

namespace Com.Facebook.Stetho.Inspector.Network
{
    partial class DownloadingAsyncPrettyPrinterFactory
    {
        partial class Request
        {
            Java.Lang.Object Java.Util.Concurrent.ICallable.Call()
            {
                return new Java.Lang.String(Call());
            }
        }
    }

    partial class ResponseBodyFileManager
    {
        partial class AsyncPrettyPrintingCallable
        {
            Java.Lang.Object Java.Util.Concurrent.ICallable.Call()
            {
                return new Java.Lang.String(Call());
            }
        }
    }
}

namespace Com.Facebook.Stetho.Inspector.Database
{
    partial class ContentProviderDatabaseDriver
    {
        public override unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.ExecuteSQLResponse ExecuteSQL(Java.Lang.Object p0, string p1, global::Com.Facebook.Stetho.Inspector.Protocol.Module.BaseDatabaseDriver.IExecuteResultHandler p2)
        {
            return ExecuteSQL(p0.ToString(), p1, p2);
        }

        public override unsafe System.Collections.Generic.IList<string> GetTableNames(Java.Lang.Object p0)
        {
            return GetTableNames(p0.ToString());
        }
    }
    partial class DatabaseDriver2Adapter
    {
        public override unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.ExecuteSQLResponse ExecuteSQL(Java.Lang.Object p0, string p1, global::Com.Facebook.Stetho.Inspector.Protocol.Module.BaseDatabaseDriver.IExecuteResultHandler p2)
        {
            return ExecuteSQL(p0.ToString(), p1, p2);
        }

        public override unsafe System.Collections.Generic.IList<string> GetTableNames(Java.Lang.Object p0)
        {
            return GetTableNames(p0.ToString());
        }
    }
    partial class SqliteDatabaseDriver
    {
        public override unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.ExecuteSQLResponse ExecuteSQL(Java.Lang.Object p0, string p1, global::Com.Facebook.Stetho.Inspector.Protocol.Module.BaseDatabaseDriver.IExecuteResultHandler p2)
        {
            return ExecuteSQL(p0.ToString(), p1, p2);
        }

        public override unsafe System.Collections.Generic.IList<string> GetTableNames(Java.Lang.Object p0)
        {
            return GetTableNames(p0.ToString());
        }
    }

}