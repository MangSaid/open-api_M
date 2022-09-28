/*
 * FlowAccount Open API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines Currency
    /// </summary>
    public enum Currency
    {
        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        NUMBER_1 = 1,

        /// <summary>
        /// Enum NUMBER_3 for value: 3
        /// </summary>
        NUMBER_3 = 3,

        /// <summary>
        /// Enum NUMBER_5 for value: 5
        /// </summary>
        NUMBER_5 = 5,

        /// <summary>
        /// Enum NUMBER_7 for value: 7
        /// </summary>
        NUMBER_7 = 7,

        /// <summary>
        /// Enum NUMBER_9 for value: 9
        /// </summary>
        NUMBER_9 = 9,

        /// <summary>
        /// Enum NUMBER_11 for value: 11
        /// </summary>
        NUMBER_11 = 11,

        /// <summary>
        /// Enum NUMBER_13 for value: 13
        /// </summary>
        NUMBER_13 = 13,

        /// <summary>
        /// Enum NUMBER_15 for value: 15
        /// </summary>
        NUMBER_15 = 15,

        /// <summary>
        /// Enum NUMBER_33 for value: 33
        /// </summary>
        NUMBER_33 = 33,

        /// <summary>
        /// Enum NUMBER_35 for value: 35
        /// </summary>
        NUMBER_35 = 35,

        /// <summary>
        /// Enum NUMBER_37 for value: 37
        /// </summary>
        NUMBER_37 = 37,

        /// <summary>
        /// Enum NUMBER_39 for value: 39
        /// </summary>
        NUMBER_39 = 39,

        /// <summary>
        /// Enum NUMBER_41 for value: 41
        /// </summary>
        NUMBER_41 = 41,

        /// <summary>
        /// Enum NUMBER_43 for value: 43
        /// </summary>
        NUMBER_43 = 43,

        /// <summary>
        /// Enum NUMBER_45 for value: 45
        /// </summary>
        NUMBER_45 = 45,

        /// <summary>
        /// Enum NUMBER_47 for value: 47
        /// </summary>
        NUMBER_47 = 47,

        /// <summary>
        /// Enum NUMBER_49 for value: 49
        /// </summary>
        NUMBER_49 = 49,

        /// <summary>
        /// Enum NUMBER_53 for value: 53
        /// </summary>
        NUMBER_53 = 53,

        /// <summary>
        /// Enum NUMBER_55 for value: 55
        /// </summary>
        NUMBER_55 = 55,

        /// <summary>
        /// Enum NUMBER_57 for value: 57
        /// </summary>
        NUMBER_57 = 57,

        /// <summary>
        /// Enum NUMBER_59 for value: 59
        /// </summary>
        NUMBER_59 = 59,

        /// <summary>
        /// Enum NUMBER_61 for value: 61
        /// </summary>
        NUMBER_61 = 61,

        /// <summary>
        /// Enum NUMBER_63 for value: 63
        /// </summary>
        NUMBER_63 = 63,

        /// <summary>
        /// Enum NUMBER_65 for value: 65
        /// </summary>
        NUMBER_65 = 65,

        /// <summary>
        /// Enum NUMBER_67 for value: 67
        /// </summary>
        NUMBER_67 = 67,

        /// <summary>
        /// Enum NUMBER_69 for value: 69
        /// </summary>
        NUMBER_69 = 69,

        /// <summary>
        /// Enum NUMBER_71 for value: 71
        /// </summary>
        NUMBER_71 = 71,

        /// <summary>
        /// Enum NUMBER_73 for value: 73
        /// </summary>
        NUMBER_73 = 73,

        /// <summary>
        /// Enum NUMBER_75 for value: 75
        /// </summary>
        NUMBER_75 = 75,

        /// <summary>
        /// Enum NUMBER_77 for value: 77
        /// </summary>
        NUMBER_77 = 77,

        /// <summary>
        /// Enum NUMBER_79 for value: 79
        /// </summary>
        NUMBER_79 = 79,

        /// <summary>
        /// Enum NUMBER_81 for value: 81
        /// </summary>
        NUMBER_81 = 81,

        /// <summary>
        /// Enum NUMBER_83 for value: 83
        /// </summary>
        NUMBER_83 = 83,

        /// <summary>
        /// Enum NUMBER_85 for value: 85
        /// </summary>
        NUMBER_85 = 85,

        /// <summary>
        /// Enum NUMBER_87 for value: 87
        /// </summary>
        NUMBER_87 = 87,

        /// <summary>
        /// Enum NUMBER_89 for value: 89
        /// </summary>
        NUMBER_89 = 89,

        /// <summary>
        /// Enum NUMBER_91 for value: 91
        /// </summary>
        NUMBER_91 = 91,

        /// <summary>
        /// Enum NUMBER_93 for value: 93
        /// </summary>
        NUMBER_93 = 93,

        /// <summary>
        /// Enum NUMBER_95 for value: 95
        /// </summary>
        NUMBER_95 = 95,

        /// <summary>
        /// Enum NUMBER_97 for value: 97
        /// </summary>
        NUMBER_97 = 97,

        /// <summary>
        /// Enum NUMBER_99 for value: 99
        /// </summary>
        NUMBER_99 = 99,

        /// <summary>
        /// Enum NUMBER_101 for value: 101
        /// </summary>
        NUMBER_101 = 101,

        /// <summary>
        /// Enum NUMBER_103 for value: 103
        /// </summary>
        NUMBER_103 = 103,

        /// <summary>
        /// Enum NUMBER_105 for value: 105
        /// </summary>
        NUMBER_105 = 105,

        /// <summary>
        /// Enum NUMBER_107 for value: 107
        /// </summary>
        NUMBER_107 = 107,

        /// <summary>
        /// Enum NUMBER_109 for value: 109
        /// </summary>
        NUMBER_109 = 109,

        /// <summary>
        /// Enum NUMBER_111 for value: 111
        /// </summary>
        NUMBER_111 = 111,

        /// <summary>
        /// Enum NUMBER_113 for value: 113
        /// </summary>
        NUMBER_113 = 113,

        /// <summary>
        /// Enum NUMBER_115 for value: 115
        /// </summary>
        NUMBER_115 = 115,

        /// <summary>
        /// Enum NUMBER_117 for value: 117
        /// </summary>
        NUMBER_117 = 117

    }

}
