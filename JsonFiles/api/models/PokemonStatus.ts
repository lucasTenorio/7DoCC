/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

import type { Abilities } from './Abilities';
import type { Form } from './Form';
import type { GameIndice } from './GameIndice';
import type { PokemonMove } from './PokemonMove';
import type { Species } from './Species';
import type { Stats } from './Stats';
import type { Types } from './Types';

export type PokemonStatus = {
    id?: number;
    isDefault?: boolean;
    location_area_encounters?: string | null;
    name?: string | null;
    order?: number;
    height?: number;
    weight?: number;
    base_experience?: number;
    moves?: Array<PokemonMove> | null;
    stats?: Array<Stats> | null;
    types?: Array<Types> | null;
    abilities?: Array<Abilities> | null;
    forms?: Array<Form> | null;
    game_indices?: Array<GameIndice> | null;
    species?: Species;
};
