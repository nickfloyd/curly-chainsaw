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
import { PagesHttpsCertificate } from './pagesHttpsCertificate';
import { PagesSourceHash } from './pagesSourceHash';

/**
* The configuration for GitHub Pages for a repository.
*/
export class GitHubPages {
    /**
    * The API address for accessing this Page resource.
    */
    'url': string;
    /**
    * The status of the most recent build of the Page.
    */
    'status': GitHubPages.StatusEnum;
    /**
    * The Pages site\'s custom domain
    */
    'cname': string | null;
    /**
    * The state if the domain is verified
    */
    'protectedDomainState'?: GitHubPages.ProtectedDomainStateEnum;
    /**
    * The timestamp when a pending domain becomes unverified.
    */
    'pendingDomainUnverifiedAt'?: Date | null;
    /**
    * Whether the Page has a custom 404 page.
    */
    'custom404': boolean = false;
    /**
    * The web address the Page can be accessed from.
    */
    'htmlUrl'?: string;
    /**
    * The process in which the Page will be built.
    */
    'buildType'?: GitHubPages.BuildTypeEnum;
    'source'?: PagesSourceHash;
    /**
    * Whether the GitHub Pages site is publicly visible. If set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site.
    */
    '_public': boolean;
    'httpsCertificate'?: PagesHttpsCertificate;
    /**
    * Whether https is enabled on the domain
    */
    'httpsEnforced'?: boolean;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "status",
            "baseName": "status",
            "type": "GitHubPages.StatusEnum"
        },
        {
            "name": "cname",
            "baseName": "cname",
            "type": "string"
        },
        {
            "name": "protectedDomainState",
            "baseName": "protected_domain_state",
            "type": "GitHubPages.ProtectedDomainStateEnum"
        },
        {
            "name": "pendingDomainUnverifiedAt",
            "baseName": "pending_domain_unverified_at",
            "type": "Date"
        },
        {
            "name": "custom404",
            "baseName": "custom_404",
            "type": "boolean"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
            "type": "string"
        },
        {
            "name": "buildType",
            "baseName": "build_type",
            "type": "GitHubPages.BuildTypeEnum"
        },
        {
            "name": "source",
            "baseName": "source",
            "type": "PagesSourceHash"
        },
        {
            "name": "_public",
            "baseName": "public",
            "type": "boolean"
        },
        {
            "name": "httpsCertificate",
            "baseName": "https_certificate",
            "type": "PagesHttpsCertificate"
        },
        {
            "name": "httpsEnforced",
            "baseName": "https_enforced",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return GitHubPages.attributeTypeMap;
    }
}

export namespace GitHubPages {
    export enum StatusEnum {
        Built = <any> 'built',
        Building = <any> 'building',
        Errored = <any> 'errored'
    }
    export enum ProtectedDomainStateEnum {
        Pending = <any> 'pending',
        Verified = <any> 'verified',
        Unverified = <any> 'unverified'
    }
    export enum BuildTypeEnum {
        Legacy = <any> 'legacy',
        Workflow = <any> 'workflow'
    }
}
