<script lang="ts">
    import { onMount } from 'svelte'
    const apiUrl: string = 'http://localhost:5005/api'

    interface ApiResponse {
        id?: string
        content: string
    }

    let apiData: ApiResponse[] | undefined = undefined
    async function fetchData() {
        try {
            const response = await fetch(`${apiUrl}/ForumThreads`)
            if (!response.ok) {
                console.log('ERROR', response.status)
            } else {
                apiData = (await response.json()) as ApiResponse[]
            }
        } catch (error) {
            console.error('Error:', error)
            error = 'An error occurred while fetching data.'
        }
    }

    onMount(async () => {
        await fetchData()
    })
</script>

<div class="flex text-read-white w-1/2 text-center mx-auto items-center">
    <div role="status" class="mx-auto h-12 text-center">
        {#if apiData === undefined}
            <p>Loading...</p>
        {:else}
            <p class="w-max">
                Hello from API:
                {#each apiData as thread}
                    <span>({thread.id}, {thread.content})</span>
                {/each}
            </p>
        {/if}
    </div>
</div>
