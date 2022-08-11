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

export class SecretScanningUpdateAlertRequest {
    /**
    * Sets the state of the secret scanning alert. Can be either `open` or `resolved`. You must provide `resolution` when you set the state to `resolved`.
    */
    'state': SecretScanningUpdateAlertRequest.StateEnum;
    /**
    * **Required when the `state` is `resolved`.** The reason for resolving the alert.
    */
    'resolution'?: SecretScanningUpdateAlertRequest.ResolutionEnum;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "state",
            "baseName": "state",
            "type": "SecretScanningUpdateAlertRequest.StateEnum"
        },
        {
            "name": "resolution",
            "baseName": "resolution",
            "type": "SecretScanningUpdateAlertRequest.ResolutionEnum"
        }    ];

    static getAttributeTypeMap() {
        return SecretScanningUpdateAlertRequest.attributeTypeMap;
    }
}

export namespace SecretScanningUpdateAlertRequest {
    export enum StateEnum {
        Open = <any> 'open',
        Resolved = <any> 'resolved'
    }
    export enum ResolutionEnum {
        Null = <any> 'null',
        FalsePositive = <any> 'false_positive',
        WontFix = <any> 'wont_fix',
        Revoked = <any> 'revoked',
        UsedInTests = <any> 'used_in_tests'
    }
}
