# Org.OpenAPITools.Model.OrgsCreateInvitationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InviteeId** | **int?** | **Required unless you provide &#x60;email&#x60;**. GitHub user ID for the person you are inviting. | [optional] 
**Email** | **string** | **Required unless you provide &#x60;invitee_id&#x60;**. Email address of the person you are inviting, which can be an existing GitHub user. | [optional] 
**Role** | **string** | The role for the new member.  \\* &#x60;admin&#x60; - Organization owners with full administrative rights to the organization and complete access to all repositories and teams.   \\* &#x60;direct_member&#x60; - Non-owner organization members with ability to see other members and join teams by invitation.   \\* &#x60;billing_manager&#x60; - Non-owner organization members with ability to manage the billing settings of your organization. | [optional] [default to RoleEnum.DirectMemberEnum]
**TeamIds** | **List<int?>** | Specify IDs for the teams you want to invite new members to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

