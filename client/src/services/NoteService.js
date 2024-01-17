import { api } from './AxiosService'
class NoteService {
  async createNote(noteData) {
    const res = await api.post("api/notes", noteData)
    console.log('Note Created', res)
  }
}
export const noteService = new NoteService()