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

export class PagesHealthCheckStatusAltDomain {
    'host'?: string;
    'uri'?: string;
    'nameservers'?: string;
    'dnsResolves'?: boolean;
    'isProxied'?: boolean | null;
    'isCloudflareIp'?: boolean | null;
    'isFastlyIp'?: boolean | null;
    'isOldIpAddress'?: boolean | null;
    'isARecord'?: boolean | null;
    'hasCnameRecord'?: boolean | null;
    'hasMxRecordsPresent'?: boolean | null;
    'isValidDomain'?: boolean;
    'isApexDomain'?: boolean;
    'shouldBeARecord'?: boolean | null;
    'isCnameToGithubUserDomain'?: boolean | null;
    'isCnameToPagesDotGithubDotCom'?: boolean | null;
    'isCnameToFastly'?: boolean | null;
    'isPointedToGithubPagesIp'?: boolean | null;
    'isNonGithubPagesIpPresent'?: boolean | null;
    'isPagesDomain'?: boolean;
    'isServedByPages'?: boolean | null;
    'isValid'?: boolean;
    'reason'?: string | null;
    'respondsToHttps'?: boolean;
    'enforcesHttps'?: boolean;
    'httpsError'?: string | null;
    'isHttpsEligible'?: boolean | null;
    'caaError'?: string | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "host",
            "baseName": "host",
            "type": "string"
        },
        {
            "name": "uri",
            "baseName": "uri",
            "type": "string"
        },
        {
            "name": "nameservers",
            "baseName": "nameservers",
            "type": "string"
        },
        {
            "name": "dnsResolves",
            "baseName": "dns_resolves",
            "type": "boolean"
        },
        {
            "name": "isProxied",
            "baseName": "is_proxied",
            "type": "boolean"
        },
        {
            "name": "isCloudflareIp",
            "baseName": "is_cloudflare_ip",
            "type": "boolean"
        },
        {
            "name": "isFastlyIp",
            "baseName": "is_fastly_ip",
            "type": "boolean"
        },
        {
            "name": "isOldIpAddress",
            "baseName": "is_old_ip_address",
            "type": "boolean"
        },
        {
            "name": "isARecord",
            "baseName": "is_a_record",
            "type": "boolean"
        },
        {
            "name": "hasCnameRecord",
            "baseName": "has_cname_record",
            "type": "boolean"
        },
        {
            "name": "hasMxRecordsPresent",
            "baseName": "has_mx_records_present",
            "type": "boolean"
        },
        {
            "name": "isValidDomain",
            "baseName": "is_valid_domain",
            "type": "boolean"
        },
        {
            "name": "isApexDomain",
            "baseName": "is_apex_domain",
            "type": "boolean"
        },
        {
            "name": "shouldBeARecord",
            "baseName": "should_be_a_record",
            "type": "boolean"
        },
        {
            "name": "isCnameToGithubUserDomain",
            "baseName": "is_cname_to_github_user_domain",
            "type": "boolean"
        },
        {
            "name": "isCnameToPagesDotGithubDotCom",
            "baseName": "is_cname_to_pages_dot_github_dot_com",
            "type": "boolean"
        },
        {
            "name": "isCnameToFastly",
            "baseName": "is_cname_to_fastly",
            "type": "boolean"
        },
        {
            "name": "isPointedToGithubPagesIp",
            "baseName": "is_pointed_to_github_pages_ip",
            "type": "boolean"
        },
        {
            "name": "isNonGithubPagesIpPresent",
            "baseName": "is_non_github_pages_ip_present",
            "type": "boolean"
        },
        {
            "name": "isPagesDomain",
            "baseName": "is_pages_domain",
            "type": "boolean"
        },
        {
            "name": "isServedByPages",
            "baseName": "is_served_by_pages",
            "type": "boolean"
        },
        {
            "name": "isValid",
            "baseName": "is_valid",
            "type": "boolean"
        },
        {
            "name": "reason",
            "baseName": "reason",
            "type": "string"
        },
        {
            "name": "respondsToHttps",
            "baseName": "responds_to_https",
            "type": "boolean"
        },
        {
            "name": "enforcesHttps",
            "baseName": "enforces_https",
            "type": "boolean"
        },
        {
            "name": "httpsError",
            "baseName": "https_error",
            "type": "string"
        },
        {
            "name": "isHttpsEligible",
            "baseName": "is_https_eligible",
            "type": "boolean"
        },
        {
            "name": "caaError",
            "baseName": "caa_error",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return PagesHealthCheckStatusAltDomain.attributeTypeMap;
    }
}

