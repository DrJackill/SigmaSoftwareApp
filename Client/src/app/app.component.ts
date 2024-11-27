import { Component } from '@angular/core';
import { HttpClient }    from '@angular/common/http';  

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'Client';
  baseUrl = "http://localhost:5215"; 

  selectedFile!: File;

  onFileSelected(event: any): void {
    this.selectedFile = event.target.files[0];
  }

  onSubmit(): void {
    this.uploadImage();
  }

  uploadImage(): void {
    const formData = new FormData();
    formData.append('image', this.selectedFile, this.selectedFile.name);
    this.http.post(`${this.baseUrl}/form`, formData).subscribe();
  }
  
constructor(private http: HttpClient) { }  
}
