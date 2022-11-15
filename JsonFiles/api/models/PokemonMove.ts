/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

import type { MoveDescription } from './MoveDescription';
import type { VersionGroupDetail } from './VersionGroupDetail';

export type PokemonMove = {
    version_group_details?: Array<VersionGroupDetail> | null;
    move?: MoveDescription;
};
