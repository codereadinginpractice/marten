// <auto-generated/>
#pragma warning disable
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Marten.Testing.Documents;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertGuidDocOperation1766073704
    public class UpsertGuidDocOperation1766073704 : Marten.Internal.Operations.StorageOperation<GuidDoc, System.Guid>
    {
        private readonly GuidDoc _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertGuidDocOperation1766073704(GuidDoc document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_guiddoc(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, GuidDoc document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }

    }

    // END: UpsertGuidDocOperation1766073704


    // START: InsertGuidDocOperation1766073704
    public class InsertGuidDocOperation1766073704 : Marten.Internal.Operations.StorageOperation<GuidDoc, System.Guid>
    {
        private readonly GuidDoc _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertGuidDocOperation1766073704(GuidDoc document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_guiddoc(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, GuidDoc document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }

    }

    // END: InsertGuidDocOperation1766073704


    // START: UpdateGuidDocOperation1766073704
    public class UpdateGuidDocOperation1766073704 : Marten.Internal.Operations.StorageOperation<GuidDoc, System.Guid>
    {
        private readonly GuidDoc _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateGuidDocOperation1766073704(GuidDoc document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_guiddoc(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, GuidDoc document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }

    }

    // END: UpdateGuidDocOperation1766073704


    // START: QueryOnlyGuidDocSelector1766073704
    public class QueryOnlyGuidDocSelector1766073704 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<GuidDoc>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyGuidDocSelector1766073704(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public GuidDoc Resolve(System.Data.Common.DbDataReader reader)
        {

            GuidDoc document;
            document = _serializer.FromJson<GuidDoc>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<GuidDoc> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            GuidDoc document;
            document = await _serializer.FromJsonAsync<GuidDoc>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyGuidDocSelector1766073704


    // START: LightweightGuidDocSelector1766073704
    public class LightweightGuidDocSelector1766073704 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<GuidDoc, System.Guid>, Marten.Linq.Selectors.ISelector<GuidDoc>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightGuidDocSelector1766073704(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public GuidDoc Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            GuidDoc document;
            document = _serializer.FromJson<GuidDoc>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<GuidDoc> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            GuidDoc document;
            document = await _serializer.FromJsonAsync<GuidDoc>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightGuidDocSelector1766073704


    // START: IdentityMapGuidDocSelector1766073704
    public class IdentityMapGuidDocSelector1766073704 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<GuidDoc, System.Guid>, Marten.Linq.Selectors.ISelector<GuidDoc>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapGuidDocSelector1766073704(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public GuidDoc Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            GuidDoc document;
            document = _serializer.FromJson<GuidDoc>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<GuidDoc> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            GuidDoc document;
            document = await _serializer.FromJsonAsync<GuidDoc>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapGuidDocSelector1766073704


    // START: DirtyTrackingGuidDocSelector1766073704
    public class DirtyTrackingGuidDocSelector1766073704 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<GuidDoc, System.Guid>, Marten.Linq.Selectors.ISelector<GuidDoc>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingGuidDocSelector1766073704(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public GuidDoc Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            GuidDoc document;
            document = _serializer.FromJson<GuidDoc>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<GuidDoc> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            GuidDoc document;
            document = await _serializer.FromJsonAsync<GuidDoc>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingGuidDocSelector1766073704


    // START: QueryOnlyGuidDocDocumentStorage1766073704
    public class QueryOnlyGuidDocDocumentStorage1766073704 : Marten.Internal.Storage.QueryOnlyDocumentStorage<GuidDoc, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyGuidDocDocumentStorage1766073704(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(GuidDoc document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(GuidDoc document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyGuidDocSelector1766073704(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyGuidDocDocumentStorage1766073704


    // START: LightweightGuidDocDocumentStorage1766073704
    public class LightweightGuidDocDocumentStorage1766073704 : Marten.Internal.Storage.LightweightDocumentStorage<GuidDoc, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightGuidDocDocumentStorage1766073704(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(GuidDoc document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(GuidDoc document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightGuidDocSelector1766073704(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightGuidDocDocumentStorage1766073704


    // START: IdentityMapGuidDocDocumentStorage1766073704
    public class IdentityMapGuidDocDocumentStorage1766073704 : Marten.Internal.Storage.IdentityMapDocumentStorage<GuidDoc, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapGuidDocDocumentStorage1766073704(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(GuidDoc document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(GuidDoc document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapGuidDocSelector1766073704(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapGuidDocDocumentStorage1766073704


    // START: DirtyTrackingGuidDocDocumentStorage1766073704
    public class DirtyTrackingGuidDocDocumentStorage1766073704 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<GuidDoc, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingGuidDocDocumentStorage1766073704(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(GuidDoc document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGuidDocOperation1766073704
            (
                document, Identity(document),
                session.Versions.ForType<GuidDoc, System.Guid>(),
                _document

            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(GuidDoc document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(GuidDoc document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingGuidDocSelector1766073704(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingGuidDocDocumentStorage1766073704


    // START: GuidDocBulkLoader1766073704
    public class GuidDocBulkLoader1766073704 : Marten.Internal.CodeGeneration.BulkLoader<GuidDoc, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<GuidDoc, System.Guid> _storage;

        public GuidDocBulkLoader1766073704(Marten.Internal.Storage.IDocumentStorage<GuidDoc, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_guiddoc(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_guiddoc_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_guiddoc (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_guiddoc_temp.\"id\", mt_doc_guiddoc_temp.\"data\", mt_doc_guiddoc_temp.\"mt_version\", mt_doc_guiddoc_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_guiddoc_temp left join public.mt_doc_guiddoc on mt_doc_guiddoc_temp.id = public.mt_doc_guiddoc.id where public.mt_doc_guiddoc.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_guiddoc target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_guiddoc_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_guiddoc_temp as select * from public.mt_doc_guiddoc limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, GuidDoc document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, GuidDoc document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }

    }

    // END: GuidDocBulkLoader1766073704


    // START: GuidDocProvider1766073704
    public class GuidDocProvider1766073704 : Marten.Internal.Storage.DocumentProvider<GuidDoc>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public GuidDocProvider1766073704(Marten.Schema.DocumentMapping mapping) : base(new GuidDocBulkLoader1766073704(new QueryOnlyGuidDocDocumentStorage1766073704(mapping)), new QueryOnlyGuidDocDocumentStorage1766073704(mapping), new LightweightGuidDocDocumentStorage1766073704(mapping), new IdentityMapGuidDocDocumentStorage1766073704(mapping), new DirtyTrackingGuidDocDocumentStorage1766073704(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: GuidDocProvider1766073704


}

