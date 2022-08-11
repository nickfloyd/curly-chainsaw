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
import { SimpleRepository } from './simpleRepository';
import { SimpleUser } from './simpleUser';

export class SecretScanningListAlertsForEnterprise200ResponseInner {
    /**
    * The security alert number.
    */
    'number'?: number;
    /**
    * The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
    */
    'createdAt'?: Date;
    /**
    * The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
    */
    'updatedAt'?: Date | null;
    /**
    * The REST API URL of the alert resource.
    */
    'url'?: string;
    /**
    * The GitHub URL of the alert resource.
    */
    'htmlUrl'?: string;
    /**
    * The REST API URL of the code locations for this alert.
    */
    'locationsUrl'?: string;
    /**
    * Sets the state of the secret scanning alert. Can be either `open` or `resolved`. You must provide `resolution` when you set the state to `resolved`.
    */
    'state'?: SecretScanningListAlertsForEnterprise200ResponseInner.StateEnum;
    /**
    * **Required when the `state` is `resolved`.** The reason for resolving the alert.
    */
    'resolution'?: SecretScanningListAlertsForEnterprise200ResponseInner.ResolutionEnum;
    /**
    * The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
    */
    'resolvedAt'?: Date | null;
    'resolvedBy'?: SimpleUser | null;
    /**
    * The type of secret that secret scanning detected.
    */
    'secretType'?: string;
    /**
    * User-friendly name for the detected secret, matching the `secret_type`. For a list of built-in patterns, see \"[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security).\"
    */
    'secretTypeDisplayName'?: string;
    /**
    * The secret that was detected.
    */
    'secret'?: string;
    'repository'?: SimpleRepository;
    /**
    * Whether push protection was bypassed for the detected secret.
    */
    'pushProtectionBypassed'?: boolean | null;
    'pushProtectionBypassedBy'?: SimpleUser | null;
    /**
    * The time that push protection was bypassed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
    */
    'pushProtectionBypassedAt'?: Date | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "number",
            "baseName": "number",
            "type": "number"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "Date"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "Date"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
            "type": "string"
        },
        {
            "name": "locationsUrl",
            "baseName": "locations_url",
            "type": "string"
        },
        {
            "name": "state",
            "baseName": "state",
            "type": "SecretScanningListAlertsForEnterprise200ResponseInner.StateEnum"
        },
        {
            "name": "resolution",
            "baseName": "resolution",
            "type": "SecretScanningListAlertsForEnterprise200ResponseInner.ResolutionEnum"
        },
        {
            "name": "resolvedAt",
            "baseName": "resolved_at",
            "type": "Date"
        },
        {
            "name": "resolvedBy",
            "baseName": "resolved_by",
            "type": "SimpleUser"
        },
        {
            "name": "secretType",
            "baseName": "secret_type",
            "type": "string"
        },
        {
            "name": "secretTypeDisplayName",
            "baseName": "secret_type_display_name",
            "type": "string"
        },
        {
            "name": "secret",
            "baseName": "secret",
            "type": "string"
        },
        {
            "name": "repository",
            "baseName": "repository",
            "type": "SimpleRepository"
        },
        {
            "name": "pushProtectionBypassed",
            "baseName": "push_protection_bypassed",
            "type": "boolean"
        },
        {
            "name": "pushProtectionBypassedBy",
            "baseName": "push_protection_bypassed_by",
            "type": "SimpleUser"
        },
        {
            "name": "pushProtectionBypassedAt",
            "baseName": "push_protection_bypassed_at",
            "type": "Date"
        }    ];

    static getAttributeTypeMap() {
        return SecretScanningListAlertsForEnterprise200ResponseInner.attributeTypeMap;
    }
}

export namespace SecretScanningListAlertsForEnterprise200ResponseInner {
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