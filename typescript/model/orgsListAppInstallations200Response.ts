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
import { Installation } from './installation';

export class OrgsListAppInstallations200Response {
    'totalCount': number;
    'installations': Array<Installation>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalCount",
            "baseName": "total_count",
            "type": "number"
        },
        {
            "name": "installations",
            "baseName": "installations",
            "type": "Array<Installation>"
        }    ];

    static getAttributeTypeMap() {
        return OrgsListAppInstallations200Response.attributeTypeMap;
    }
}
