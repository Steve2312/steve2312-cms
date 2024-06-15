import { Routes } from '@angular/router';
import { ComponentsPage } from './pages/components/components.page';
import { ModelsPage } from './pages/models/models.page';
import { EntitiesPage } from './pages/entities/entities.page';
import { ModelCreatePage } from './pages/models/model-create/model-create.page';

export const routes: Routes = [
  {
    path: 'components',
    component: ComponentsPage,
  },
  {
    path: 'models',
    component: ModelsPage,
  },
  {
    path: 'models/create',
    component: ModelCreatePage,
  },
  {
    path: 'entities',
    component: EntitiesPage,
  },
];
