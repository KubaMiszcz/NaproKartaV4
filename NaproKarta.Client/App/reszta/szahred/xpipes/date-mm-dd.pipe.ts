import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'dateMmDd'
})
export class DateMmDdPipe implements PipeTransform {

  transform(value: any, args?: any): any {
    return null;
  }

}
