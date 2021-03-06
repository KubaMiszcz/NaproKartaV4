import { IObservation } from './iobservation';

export interface ICycle {
  id: number;
  note: string;
  observations: IObservation[];
  numberInChart: number;
  chartId: number;
}

export class Cycle implements ICycle {
  id: number;
  note: string;
  observations: IObservation[];
  numberInChart: number;
  chartId: number;
}
