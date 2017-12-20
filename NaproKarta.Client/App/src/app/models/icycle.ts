import { IObservation } from './iobservation';

export interface ICycle {
    note: string;
    observations: IObservation[];
    numberInChart: number;

}

export class Cycle implements ICycle {
    note: string;
    observations: IObservation[];
    numberInChart: number;
}

