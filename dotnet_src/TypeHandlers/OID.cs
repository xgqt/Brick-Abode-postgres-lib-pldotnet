// <copyright file="OID.cs" company="Brick Abode">
//
// PL/.NET (pldotnet) - PostgreSQL support for .NET C# and F# as
//                      procedural languages (PL)
//
//
// Copyright (c) 2023 Brick Abode
//
// This code is subject to the terms of the PostgreSQL License.
// The full text of the license can be found in the LICENSE file
// at the top level of the pldotnet repository.
//
// </copyright>

namespace PlDotNET.Handler
{
    public enum OID : uint
    {
        BOOLOID = 16,
        BYTEAOID = 17,
        CHAROID = 18,
        NAMEOID = 19,
        INT8OID = 20,
        INT2OID = 21,
        INT2VECTOROID = 22,
        INT4OID = 23,
        REGPROCOID = 24,
        TEXTOID = 25,
        OIDOID = 26,
        TIDOID = 27,
        XIDOID = 28,
        CIDOID = 29,
        OIDVECTOROID = 30,
        JSONOID = 114,
        XMLOID = 142,
        PG_NODE_TREEOID = 194,
        PG_NDISTINCTOID = 3361,
        PG_DEPENDENCIESOID = 3402,
        PG_MCV_LISTOID = 5017,
        PG_DDL_COMMANDOID = 32,
        XID8OID = 5069,
        POINTOID = 600,
        LSEGOID = 601,
        PATHOID = 602,
        BOXOID = 603,
        POLYGONOID = 604,
        LINEOID = 628,
        FLOAT4OID = 700,
        FLOAT8OID = 701,
        UNKNOWNOID = 705,
        CIRCLEOID = 718,
        MONEYOID = 790,
        MACADDROID = 829,
        INETOID = 869,
        CIDROID = 650,
        MACADDR8OID = 774,
        ACLITEMOID = 1033,
        BPCHAROID = 1042,
        VARCHAROID = 1043,
        DATEOID = 1082,
        TIMEOID = 1083,
        TIMESTAMPOID = 1114,
        TIMESTAMPTZOID = 1184,
        INTERVALOID = 1186,
        TIMETZOID = 1266,
        BITOID = 1560,
        VARBITOID = 1562,
        NUMERICOID = 1700,
        REFCURSOROID = 1790,
        REGPROCEDUREOID = 2202,
        REGOPEROID = 2203,
        REGOPERATOROID = 2204,
        REGCLASSOID = 2205,
        REGCOLLATIONOID = 4191,
        REGTYPEOID = 2206,
        REGROLEOID = 4096,
        REGNAMESPACEOID = 4089,
        UUIDOID = 2950,
        PG_LSNOID = 3220,
        TSVECTOROID = 3614,
        GTSVECTOROID = 3642,
        TSQUERYOID = 3615,
        REGCONFIGOID = 3734,
        REGDICTIONARYOID = 3769,
        JSONBOID = 3802,
        JSONPATHOID = 4072,
        TXID_SNAPSHOTOID = 2970,
        PG_SNAPSHOTOID = 5038,
        INT4RANGEOID = 3904,
        NUMRANGEOID = 3906,
        TSRANGEOID = 3908,
        TSTZRANGEOID = 3910,
        DATERANGEOID = 3912,
        INT8RANGEOID = 3926,
        INT4MULTIRANGEOID = 4451,
        NUMMULTIRANGEOID = 4532,
        TSMULTIRANGEOID = 4533,
        TSTZMULTIRANGEOID = 4534,
        DATEMULTIRANGEOID = 4535,
        INT8MULTIRANGEOID = 4536,
        RECORDOID = 2249,
        RECORDARRAYOID = 2287,
        CSTRINGOID = 2275,
        ANYOID = 2276,
        ANYARRAYOID = 2277,
        VOIDOID = 2278,
        TRIGGEROID = 2279,
        EVENT_TRIGGEROID = 3838,
        LANGUAGE_HANDLEROID = 2280,
        INTERNALOID = 2281,
        ANYELEMENTOID = 2283,
        ANYNONARRAYOID = 2776,
        ANYENUMOID = 3500,
        FDW_HANDLEROID = 3115,
        INDEX_AM_HANDLEROID = 325,
        TSM_HANDLEROID = 3310,
        TABLE_AM_HANDLEROID = 269,
        ANYRANGEOID = 3831,
        ANYCOMPATIBLEOID = 5077,
        ANYCOMPATIBLEARRAYOID = 5078,
        ANYCOMPATIBLENONARRAYOID = 5079,
        ANYCOMPATIBLERANGEOID = 5080,
        ANYMULTIRANGEOID = 4537,
        ANYCOMPATIBLEMULTIRANGEOID = 4538,
        PG_BRIN_BLOOM_SUMMARYOID = 4600,
        PG_BRIN_MINMAX_MULTI_SUMMARYOID = 4601,
        BOOLARRAYOID = 1000,
        BYTEAARRAYOID = 1001,
        CHARARRAYOID = 1002,
        NAMEARRAYOID = 1003,
        INT8ARRAYOID = 1016,
        INT2ARRAYOID = 1005,
        INT2VECTORARRAYOID = 1006,
        INT4ARRAYOID = 1007,
        REGPROCARRAYOID = 1008,
        TEXTARRAYOID = 1009,
        OIDARRAYOID = 1028,
        TIDARRAYOID = 1010,
        XIDARRAYOID = 1011,
        CIDARRAYOID = 1012,
        OIDVECTORARRAYOID = 1013,
        PG_TYPEARRAYOID = 210,
        PG_ATTRIBUTEARRAYOID = 270,
        PG_PROCARRAYOID = 272,
        PG_CLASSARRAYOID = 273,
        JSONARRAYOID = 199,
        XMLARRAYOID = 143,
        XID8ARRAYOID = 271,
        POINTARRAYOID = 1017,
        LSEGARRAYOID = 1018,
        PATHARRAYOID = 1019,
        BOXARRAYOID = 1020,
        POLYGONARRAYOID = 1027,
        LINEARRAYOID = 629,
        FLOAT4ARRAYOID = 1021,
        FLOAT8ARRAYOID = 1022,
        CIRCLEARRAYOID = 719,
        MONEYARRAYOID = 791,
        MACADDRARRAYOID = 1040,
        INETARRAYOID = 1041,
        CIDRARRAYOID = 651,
        MACADDR8ARRAYOID = 775,
        ACLITEMARRAYOID = 1034,
        BPCHARARRAYOID = 1014,
        VARCHARARRAYOID = 1015,
        DATEARRAYOID = 1182,
        TIMEARRAYOID = 1183,
        TIMESTAMPARRAYOID = 1115,
        TIMESTAMPTZARRAYOID = 1185,
        INTERVALARRAYOID = 1187,
        TIMETZARRAYOID = 1270,
        BITARRAYOID = 1561,
        VARBITARRAYOID = 1563,
        NUMERICARRAYOID = 1231,
        REFCURSORARRAYOID = 2201,
        REGPROCEDUREARRAYOID = 2207,
        REGOPERARRAYOID = 2208,
        REGOPERATORARRAYOID = 2209,
        REGCLASSARRAYOID = 2210,
        REGCOLLATIONARRAYOID = 4192,
        REGTYPEARRAYOID = 2211,
        REGROLEARRAYOID = 4097,
        REGNAMESPACEARRAYOID = 4090,
        UUIDARRAYOID = 2951,
        PG_LSNARRAYOID = 3221,
        TSVECTORARRAYOID = 3643,
        GTSVECTORARRAYOID = 3644,
        TSQUERYARRAYOID = 3645,
        REGCONFIGARRAYOID = 3735,
        REGDICTIONARYARRAYOID = 3770,
        JSONBARRAYOID = 3807,
        JSONPATHARRAYOID = 4073,
        TXID_SNAPSHOTARRAYOID = 2949,
        PG_SNAPSHOTARRAYOID = 5039,
        INT4RANGEARRAYOID = 3905,
        NUMRANGEARRAYOID = 3907,
        TSRANGEARRAYOID = 3909,
        TSTZRANGEARRAYOID = 3911,
        DATERANGEARRAYOID = 3913,
        INT8RANGEARRAYOID = 3927,
        INT4MULTIRANGEARRAYOID = 6150,
        NUMMULTIRANGEARRAYOID = 6151,
        TSMULTIRANGEARRAYOID = 6152,
        TSTZMULTIRANGEARRAYOID = 6153,
        DATEMULTIRANGEARRAYOID = 6155,
        INT8MULTIRANGEARRAYOID = 6157,
        CSTRINGARRAYOID = 1263,
    }
}