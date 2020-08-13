import { Guest } from "../guest";

export interface GuestListResponse {
    success: boolean;
    guests: Guest[];
    count: number;
    perPage: number;
    page: number;
}