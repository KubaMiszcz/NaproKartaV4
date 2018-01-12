import { INote } from './inote';

export interface IObservation {
  id: number;
  cycleId: number;
  numberInCycle: number;
  marker: string;
  peakDayNumber: number;
  date: Date;
  letter: string;
  isB: boolean;
  numTimes: string;
  cipher: string;
  cipherCd: string;
  comments: any; //????
  notes: INote[];
}

export class Observation implements IObservation {
  id: number;
  cycleId: number;
  numberInCycle: number;
  marker: string;
  peakDayNumber: number;
  date: Date;
  letter: string;
  isB: boolean;
  numTimes: string;
  cipher: string;
  cipherCd: string;
  comments: any; //????
  notes: INote[];
}
