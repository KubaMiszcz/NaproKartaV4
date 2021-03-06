export interface INote {
  id: number;
  content: string;
  isImportant: boolean;
  observationId: number;
}

export class Note implements INote {
  id: number;
  content: string;
  isImportant: boolean;
  observationId: number;
}
