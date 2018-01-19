import { INote } from './inote';
import { Url } from 'url';

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
  pictureUrl: Url;// URL
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
  pictureUrl: Url;// URL
}
