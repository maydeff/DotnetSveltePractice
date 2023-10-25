export type Category = {
    id?: number,
    name: string,
    iconName: string,
    numberOfThreads: number,
}

export const categories: Category[] = [
    {
        id: 1,
        name: 'Gaming',
        iconName: 'i-mdi-home',
        numberOfThreads: 5
    },
    {
        id: 2,
        name: 'Science',
        iconName: 'i-mdi-atom',
        numberOfThreads: 10
    },
]