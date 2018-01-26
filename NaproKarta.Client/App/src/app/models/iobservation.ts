import { INote } from './inote';
import { Url } from 'url';
import { IPicture } from './ipicture';

export interface IObservation {
  numberOfParentCycleInChart: number;
  parentChartId: number;
  //observations parameters
  id: number;
  numberInCycle: number;
  date: Date;
  marker: string;
  peakDayNumber: number;
  letter: string;
  isB: boolean;
  cipher: string;
  cipherCd: string;
  numTimes: string;
  comments: any; //????
  notes: INote[];
  pictures: IPicture[]; // URL
}

export class Observation implements IObservation {
  numberOfParentCycleInChart: number;
  parentChartId: number;
  //observations parameters
  id: number;
  numberInCycle: number;
  date: Date;
  marker: string;
  peakDayNumber: number;
  letter: string;
  isB: boolean;
  cipher: string;
  cipherCd: string;
  numTimes: string;
  comments: any; //????
  notes: INote[];
  pictures: IPicture[]; // URL
}
