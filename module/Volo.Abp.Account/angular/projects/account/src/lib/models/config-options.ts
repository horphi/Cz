import { eAccountComponents } from '../enums';
import { EditFormPropContributorCallback } from '@abp/ng.components/extensible';
import { UpdateProfileDto } from '@abp/ng.account.core/proxy';

export interface AccountConfigOptions {
  redirectUrl?: string;
  isPersonalSettingsChangedConfirmationActive?: boolean;
  editFormPropContributors?: AccountEditFormPropContributors;
}
export type AccountEditFormPropContributors = Partial<{
  [eAccountComponents.PersonalSettings]: EditFormPropContributorCallback<UpdateProfileDto>[];
}>;
