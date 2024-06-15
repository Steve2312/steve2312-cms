import { Component, OnInit } from '@angular/core';
import { HeadingComponent } from '../../components/atoms/heading/heading.component';
import { ButtonComponent } from '../../components/atoms/button/button.component';
import { TableComponent } from '../../components/molecules/table/table.component';
import { TableHeaderComponent } from '../../components/atoms/table-header/table-header.component';
import { TableRowComponent } from '../../components/atoms/table-row/table-row.component';
import { ModelService } from '../../services/model.service';
import { Model } from '../../interfaces/model.interface';
import { TableDataComponent } from '../../components/atoms/table-data/table-data.component';
import { StatusComponent } from '../../components/atoms/status/status.component';
import { Router } from '@angular/router';
import { LoaderComponent } from '../../components/molecules/loader/loader.component';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-models',
  standalone: true,
  imports: [
    HeadingComponent,
    ButtonComponent,
    TableComponent,
    TableHeaderComponent,
    TableRowComponent,
    TableDataComponent,
    StatusComponent,
    LoaderComponent,
    DatePipe,
  ],
  templateUrl: './models.page.html',
})
export class ModelsPage implements OnInit {
  public models?: Model[];

  constructor(
    private service: ModelService,
    public router: Router,
  ) {}

  ngOnInit(): void {
    this.service.getModels().subscribe((models) => {
      this.models = models;
    });
  }
}
