// <auto-generated/>
#pragma warning disable
using DocumentDbTests.Bugs;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertDocHolderOperation1892370027
    public class UpsertDocHolderOperation1892370027 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.DocHolder, System.Guid>
    {
        private readonly DocumentDbTests.Bugs.DocHolder _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertDocHolderOperation1892370027(DocumentDbTests.Bugs.DocHolder document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_docholder(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session)
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

    // END: UpsertDocHolderOperation1892370027
    
    
    // START: InsertDocHolderOperation1892370027
    public class InsertDocHolderOperation1892370027 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.DocHolder, System.Guid>
    {
        private readonly DocumentDbTests.Bugs.DocHolder _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertDocHolderOperation1892370027(DocumentDbTests.Bugs.DocHolder document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_docholder(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session)
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

    // END: InsertDocHolderOperation1892370027
    
    
    // START: UpdateDocHolderOperation1892370027
    public class UpdateDocHolderOperation1892370027 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.DocHolder, System.Guid>
    {
        private readonly DocumentDbTests.Bugs.DocHolder _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateDocHolderOperation1892370027(DocumentDbTests.Bugs.DocHolder document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_docholder(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session)
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

    // END: UpdateDocHolderOperation1892370027
    
    
    // START: QueryOnlyDocHolderSelector1892370027
    public class QueryOnlyDocHolderSelector1892370027 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.DocHolder>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyDocHolderSelector1892370027(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.DocHolder Resolve(System.Data.Common.DbDataReader reader)
        {

            DocumentDbTests.Bugs.DocHolder document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.DocHolder>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.DocHolder> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            DocumentDbTests.Bugs.DocHolder document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.DocHolder>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyDocHolderSelector1892370027
    
    
    // START: LightweightDocHolderSelector1892370027
    public class LightweightDocHolderSelector1892370027 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<DocumentDbTests.Bugs.DocHolder, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.DocHolder>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightDocHolderSelector1892370027(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.DocHolder Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            DocumentDbTests.Bugs.DocHolder document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.DocHolder>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.DocHolder> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            DocumentDbTests.Bugs.DocHolder document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.DocHolder>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightDocHolderSelector1892370027
    
    
    // START: IdentityMapDocHolderSelector1892370027
    public class IdentityMapDocHolderSelector1892370027 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<DocumentDbTests.Bugs.DocHolder, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.DocHolder>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapDocHolderSelector1892370027(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.DocHolder Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.DocHolder document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.DocHolder>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.DocHolder> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.DocHolder document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.DocHolder>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapDocHolderSelector1892370027
    
    
    // START: DirtyTrackingDocHolderSelector1892370027
    public class DirtyTrackingDocHolderSelector1892370027 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<DocumentDbTests.Bugs.DocHolder, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.DocHolder>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingDocHolderSelector1892370027(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.DocHolder Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.DocHolder document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.DocHolder>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.DocHolder> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.DocHolder document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.DocHolder>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingDocHolderSelector1892370027
    
    
    // START: QueryOnlyDocHolderDocumentStorage1892370027
    public class QueryOnlyDocHolderDocumentStorage1892370027 : Marten.Internal.Storage.QueryOnlyDocumentStorage<DocumentDbTests.Bugs.DocHolder, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyDocHolderDocumentStorage1892370027(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.DocHolder document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.DocHolder document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyDocHolderSelector1892370027(session, _document);
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

    // END: QueryOnlyDocHolderDocumentStorage1892370027
    
    
    // START: LightweightDocHolderDocumentStorage1892370027
    public class LightweightDocHolderDocumentStorage1892370027 : Marten.Internal.Storage.LightweightDocumentStorage<DocumentDbTests.Bugs.DocHolder, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightDocHolderDocumentStorage1892370027(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.DocHolder document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.DocHolder document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightDocHolderSelector1892370027(session, _document);
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

    // END: LightweightDocHolderDocumentStorage1892370027
    
    
    // START: IdentityMapDocHolderDocumentStorage1892370027
    public class IdentityMapDocHolderDocumentStorage1892370027 : Marten.Internal.Storage.IdentityMapDocumentStorage<DocumentDbTests.Bugs.DocHolder, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapDocHolderDocumentStorage1892370027(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.DocHolder document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.DocHolder document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapDocHolderSelector1892370027(session, _document);
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

    // END: IdentityMapDocHolderDocumentStorage1892370027
    
    
    // START: DirtyTrackingDocHolderDocumentStorage1892370027
    public class DirtyTrackingDocHolderDocumentStorage1892370027 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<DocumentDbTests.Bugs.DocHolder, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingDocHolderDocumentStorage1892370027(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.DocHolder document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDocHolderOperation1892370027
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.DocHolder, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.DocHolder document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.DocHolder document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingDocHolderSelector1892370027(session, _document);
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

    // END: DirtyTrackingDocHolderDocumentStorage1892370027
    
    
    // START: DocHolderBulkLoader1892370027
    public class DocHolderBulkLoader1892370027 : Marten.Internal.CodeGeneration.BulkLoader<DocumentDbTests.Bugs.DocHolder, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Bugs.DocHolder, System.Guid> _storage;

        public DocHolderBulkLoader1892370027(Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Bugs.DocHolder, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_docholder(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_docholder_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_docholder (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_docholder_temp.\"id\", mt_doc_docholder_temp.\"data\", mt_doc_docholder_temp.\"mt_version\", mt_doc_docholder_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_docholder_temp left join public.mt_doc_docholder on mt_doc_docholder_temp.id = public.mt_doc_docholder.id where public.mt_doc_docholder.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_docholder target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_docholder_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_docholder_temp as select * from public.mt_doc_docholder limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Bugs.DocHolder document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Bugs.DocHolder document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
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

    // END: DocHolderBulkLoader1892370027
    
    
    // START: DocHolderProvider1892370027
    public class DocHolderProvider1892370027 : Marten.Internal.Storage.DocumentProvider<DocumentDbTests.Bugs.DocHolder>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DocHolderProvider1892370027(Marten.Schema.DocumentMapping mapping) : base(new DocHolderBulkLoader1892370027(new QueryOnlyDocHolderDocumentStorage1892370027(mapping)), new QueryOnlyDocHolderDocumentStorage1892370027(mapping), new LightweightDocHolderDocumentStorage1892370027(mapping), new IdentityMapDocHolderDocumentStorage1892370027(mapping), new DirtyTrackingDocHolderDocumentStorage1892370027(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: DocHolderProvider1892370027
    
    
}
