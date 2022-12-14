/**
 * GitHub v3 REST API
 * GitHub\'s v3 REST API.
 *
 * The version of the OpenAPI document: 1.1.4
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { RequestFile } from './models';

export class CODEOWNERSErrorsErrorsInner {
    /**
    * The line number where this errors occurs.
    */
    'line': number;
    /**
    * The column number where this errors occurs.
    */
    'column': number;
    /**
    * The contents of the line where the error occurs.
    */
    'source'?: string;
    /**
    * The type of error.
    */
    'kind': string;
    /**
    * Suggested action to fix the error. This will usually be `null`, but is provided for some common errors.
    */
    'suggestion'?: string | null;
    /**
    * A human-readable description of the error, combining information from multiple fields, laid out for display in a monospaced typeface (for example, a command-line setting).
    */
    'message': string;
    /**
    * The path of the file where the error occured.
    */
    'path': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "line",
            "baseName": "line",
            "type": "number"
        },
        {
            "name": "column",
            "baseName": "column",
            "type": "number"
        },
        {
            "name": "source",
            "baseName": "source",
            "type": "string"
        },
        {
            "name": "kind",
            "baseName": "kind",
            "type": "string"
        },
        {
            "name": "suggestion",
            "baseName": "suggestion",
            "type": "string"
        },
        {
            "name": "message",
            "baseName": "message",
            "type": "string"
        },
        {
            "name": "path",
            "baseName": "path",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return CODEOWNERSErrorsErrorsInner.attributeTypeMap;
    }
}

